using System.Threading.Tasks;
using Grpc.Core;

namespace grpcInfoServer.Services;

public class InfoService : Information.InformationBase
{
    private readonly ILogger<InfoService> _logger;
    public InfoService(ILogger<InfoService> logger)
    {
        _logger = logger;
    }
    public override async Task RecieveInfo(InfoRequest request, IServerStreamWriter<InfoResponse> responseStream, ServerCallContext context)
    {
        Console.WriteLine($"request sended:{request.Name}");
        for (int i = 0; i < 10; i++)
        {
            await Task.Delay(1000);
            string position = request.Position ? "Active" : "Passive";
            await responseStream.WriteAsync(new InfoResponse { Message=$"{i}: Information sended:{request.Name} Position:{position}"});
        }
    }

}
