using System;
using Grpc.Core;

namespace grpcStreamServer.Services
{
	public class ServerStreamService: Email.EmailBase
    {
        private readonly ILogger<ServerStreamService> _logger;
        public ServerStreamService(ILogger<ServerStreamService> logger)
        {
            _logger = logger;
        }
        public override async Task<EmailResponse> SendMessage(IAsyncStreamReader<EmailRequest> requestStream, ServerCallContext context)
        {
            while (await requestStream.MoveNext(context.CancellationToken))
            {
                await Task.Delay(1000);
                Console.WriteLine($"Message:{requestStream.Current.Message}  Name:{requestStream.Current.Name}");
            }
            return new EmailResponse { Message="Email Successfully sended"};
        }
    }
}

