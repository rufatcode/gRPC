using Grpc.Core;
using grpcServer;

namespace grpcServer.Services;

public class GreeterService : Greeter.GreeterBase
{
    private readonly ILogger<GreeterService> _logger;
    public GreeterService(ILogger<GreeterService> logger)
    {
        _logger = logger;
    }

    public override Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context)
    {
        Console.WriteLine("request successfully sended");
        return Task.FromResult(new HelloReply
        {
            Message = "Name:" + request.Name + "\nSureName:"+request.SureName+"\nAge:"+request.Age
        });
    }
}
