using Grpc.Core;

namespace grpcMessageServer.Services;

public class MessageService : Message.MessageBase
{
    private readonly ILogger<MessageService> _logger;
    public MessageService(ILogger<MessageService> logger)
    {
        _logger = logger;
    }
    public override Task<MessageResponse> SendMessage(MessageRequest request, ServerCallContext context)
    {
        Console.WriteLine("Message Successflly sended");
        return Task.FromResult(new MessageResponse
        {
            Message = "Name:" + request.Name + "\nMessage:" + request.Message 
        });
    }

}
