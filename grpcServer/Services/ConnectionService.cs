using System;
using Grpc.Core;

namespace grpcConnectionServer.Services
{
	public class ConnectionService: Connection.ConnectionBase
    {
        private readonly ILogger<ConnectionService> _logger;
        public ConnectionService(ILogger<ConnectionService> logger)
        {
            _logger = logger;
        }
        //Unary


        //public override async Task<ConnectionResponse> Connect(ConnectionRequest request, ServerCallContext context)
        //{
        //    Console.WriteLine("request accpeted");
        //    return new ConnectionResponse
        //    {
        //        Message=request.Message,
        //        Name=request.Name
        //    };
        //}

        //Server Stream

        //public override async Task Connect(ConnectionRequest request, IServerStreamWriter<ConnectionResponse> responseStream, ServerCallContext context)
        //{
        //    Console.WriteLine($"request message:{request.Message}|User:{request.Name}");
        //    for (int i = 0; i < 10; i++)
        //    {
        //        await Task.Delay(1000);
        //        await responseStream.WriteAsync(new ConnectionResponse { Message = "Azerbijan", Name = i + ":Rufat123" });
        //    }

        //}

        //Client Stream

        //public override async Task<ConnectionResponse> Connect(IAsyncStreamReader<ConnectionRequest> requestStream, ServerCallContext context)
        //{
        //    while (await requestStream.MoveNext(context.CancellationToken))
        //    {

        //        Console.WriteLine($" Client Meesage:{requestStream.Current.Message}|Client Name:{requestStream.Current.Name}");
        //    }

        //    return new ConnectionResponse { Message = "Server Message", Name = "Server123" };
        //}

        //Bi Directional Stream

        public override async Task Connect(IAsyncStreamReader<ConnectionRequest> requestStream, IServerStreamWriter<ConnectionResponse> responseStream, ServerCallContext context)
        {
            var request= Task.Run(async () =>
            {

                while (await requestStream.MoveNext(context.CancellationToken))
                {
                    await Task.Delay(1000);
                    Console.WriteLine($"request Message:{requestStream.Current.Message}|request user:{requestStream.Current.Name}");
                }
            });
            var response= Task.Run(async () =>
            {

                for (int i = 0; i < 10; i++)
                {
                    await responseStream.WriteAsync(new ConnectionResponse { Message = "server response", Name = "Server" + i + 1 });
                }
            });

            await request;
            await response;
            
            
        }

    }
}

