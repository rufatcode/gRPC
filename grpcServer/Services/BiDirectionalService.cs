using System;
using Grpc.Core;
using grpcBiDirectioanlarStream;
namespace grpcBiDirectioanlarStream.Services
{
    public class BiDirectionalService : Chat.ChatBase
    {
        private readonly ILogger<BiDirectionalService> _logger;
        public BiDirectionalService(ILogger<BiDirectionalService> logger)
        {
            _logger = logger;
        }
        public override async Task SendMessage(IAsyncStreamReader<MessageRequest> requestStream, IServerStreamWriter<MessageResponse> responseStream, ServerCallContext context)
        {
           
            var request= Task.Run(async () =>
            {
                while (await requestStream.MoveNext(context.CancellationToken))
                {
                    await Task.Delay(1000);
                    Console.WriteLine($"User:{requestStream.Current.Name}|Meesage:{requestStream.Current.Message}");
                }
            });

            var response= Task.Run(async () =>
            {
                for (int i = 0; i < 10; i++)
                {
                    await responseStream.WriteAsync(new MessageResponse { Message = "Hello I am Okay and you", Name = i + ":Asim123" });
                }
            });
            await request;
            await response;
        }
    }
}

