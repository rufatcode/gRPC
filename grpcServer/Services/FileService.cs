using System;
using Google.Protobuf;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;

namespace grpcFileServer.Services
{
	public class FileService: FileProses.FileProsesBase
    {
        private readonly ILogger<FileService> _logger;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public FileService(ILogger<FileService> logger,IWebHostEnvironment webHostEnvironment)
        {
            _logger = logger;
            _webHostEnvironment = webHostEnvironment;
        }
        public override async Task<Empty> FileUpload(IAsyncStreamReader<BytesContent> requestStream, ServerCallContext context)
        {
            string path = Path.Combine(_webHostEnvironment.WebRootPath, "files");
            if (Directory.Exists(path))
                Directory.CreateDirectory(path);

            FileStream fileStream = null;
            try
            {
                decimal chankSize = 0;
                while (await requestStream.MoveNext(context.CancellationToken))
                {
                    int count = 0;
                    if (count++==0)
                    {
                        fileStream = new(Path.Combine(path, requestStream.Current.Info.FileName+"."+requestStream.Current.Info.FileExtention), FileMode.CreateNew);
                        fileStream.SetLength(requestStream.Current.FileSize);
                    }
                    var buffer = requestStream.Current.Buffer.ToByteArray();
                    await fileStream.WriteAsync(buffer, 0, buffer.Length);
                    Console.WriteLine($"{Math.Round(chankSize+=requestStream.Current.ReadByte*100)/100}");
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            await fileStream.DisposeAsync();
            fileStream.Close();
            return new Empty();
        }
        public override async Task FileDownLoad(FileInfo request, IServerStreamWriter<BytesContent> responseStream, ServerCallContext context)
        {
            string path = Path.Combine(_webHostEnvironment.WebRootPath, request.FileName + "." + request.FileExtention);
            using FileStream fileStream = new(path, FileMode.Open, FileAccess.Read);
            byte[] buffer = new byte[2048];
            BytesContent bytesContent = new()
            {
                FileSize = fileStream.Length,
                Info = new() { FileName = Path.GetFileNameWithoutExtension(fileStream.Name), FileExtention = Path.GetExtension(fileStream.Name) },
                ReadByte = 0
            };
            while ((bytesContent.ReadByte=await fileStream.ReadAsync(buffer,0,buffer.Length))>0)
            {
                bytesContent.Buffer = ByteString.CopyFrom(buffer);
                await responseStream.WriteAsync(bytesContent);
            }
            fileStream.Close();
        }

    }
}

