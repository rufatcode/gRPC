// See https://aka.ms/new-console-template for more information
using Grpc.Net.Client;
using grpcMessageClient;
using grpcInfoClient;
using grpcServer;
using Grpc.Core;
using grpcStreamServer;
using grpcBiDirectioanlarStream;
using grpcConnectionClient;

var channal = GrpcChannel.ForAddress("http://localhost:5052");
//await CallGreater();
//await CallMessage();
//await CallInfo();
//await ServerStream();
//await BiDerecionalStream();
await Connection();
async Task CallGreater()
{
    
    var greatClient = new Greeter.GreeterClient(channal);
    HelloReply resoult = await greatClient.SayHelloAsync(new HelloRequest { Name = "Rufat",SureName="Ismayilov",Age=20 });
    Console.WriteLine(resoult.Message);

}

async Task CallMessage()
{
    var messageClient = new Message.MessageClient(channal);
    grpcMessageClient.MessageResponse resoult = await messageClient.SendMessageAsync(new grpcMessageClient.MessageRequest { Name = "Rufat", Message = "Hello I am Rufat"});
    Console.WriteLine(resoult.Message);

}

async Task CallInfo()
{
    var infoClient = new Information.InformationClient(channal);
    CancellationToken cancellationToken = new();
   var resoult =  infoClient.RecieveInfo(new InfoRequest { Name = "Rufat", Position = true});
    while (await resoult.ResponseStream.MoveNext(cancellationToken))
    {
        
        Console.WriteLine(resoult.ResponseStream.Current.Message);
    }

}

async Task ServerStream()
{
    var infoClient = new Email.EmailClient(channal);
    var resoult = infoClient.SendMessage();
    for (int i = 0; i < 10; i++)
    {
        await resoult.RequestStream.WriteAsync(new EmailRequest { Message = "I send email for reset password", Name = "Rufat" });
    }
    await resoult.RequestStream.CompleteAsync();
    Console.WriteLine(await resoult.ResponseAsync);

}

async Task BiDerecionalStream()
{
    var messageClient = new Chat.ChatClient(channal);
    var resoult = messageClient.SendMessage();
    var request= Task.Run(async() =>
    {
        for (int i = 0; i < 10; i++)
        { 
            await resoult.RequestStream.WriteAsync(new grpcBiDirectioanlarStream.MessageRequest { Message = "Hello what are you doing?", Name = i+":Rufat122" });
        }
    });
    
    CancellationToken cancellationToken = new ();
    var response= Task.Run(async () =>
    {
        while (await resoult.ResponseStream.MoveNext(cancellationToken))
        {
            await Task.Delay(1000);
            Console.WriteLine($"User:{resoult.ResponseStream.Current.Name}|Message:{resoult.ResponseStream.Current.Message}");
        }
    });
    await request;
    await resoult.RequestStream.CompleteAsync();
    await response;

}

async Task Connection()
{
    //Unary

    //var connectionClient = new Connection.ConnectionClient(channal);
    //var resoult = connectionClient.Connect(new ConnectionRequest { Message = "Hi", Name = "Rufat123" });
    //Console.WriteLine($"Meesage:{resoult.Message}|Name:{resoult.Name}");


    //Client Stream


    //var connectionClient = new Connection.ConnectionClient(channal);
    //var resoult = connectionClient.Connect(new ConnectionRequest { Message = "Hi", Name = "Rufat123" });
    //CancellationToken cancellationToken = new();
    //while (await resoult.ResponseStream.MoveNext(cancellationToken))
    //{
    //    await Task.Delay(1000);
    //    Console.WriteLine($"Message:{resoult.ResponseStream.Current.Message}|User:{resoult.ResponseStream.Current.Name}");
    //}


    //Server stream

    //var connectionClient = new Connection.ConnectionClient(channal);
    //var resoult = connectionClient.Connect();
    //for (int i = 0; i < 10; i++)
    //{
    //    await Task.Delay(1000);
    //    await resoult.RequestStream.WriteAsync(new ConnectionRequest { Message = "Client Message", Name = "Client"+i  });
    //}

    //await resoult.RequestStream.CompleteAsync();

    //Console.WriteLine($"Response message:{resoult.ResponseAsync.Result.Message}|Response CLient:{resoult.ResponseAsync.Result.Name}");

    //Bi Directioanal Stream

    var connectionClient = new Connection.ConnectionClient(channal);
    var resoult = connectionClient.Connect();

    var request = Task.Run(async () =>
    {
        for (int i = 0; i < 10; i++)
        {
            await resoult.RequestStream.WriteAsync(new ConnectionRequest { Message = "Client request", Name = "Client" + i + 1 });
        }
    });
    var response = Task.Run(async () =>
    {
        CancellationToken cancellationToken = new();
        while (await resoult.ResponseStream.MoveNext(cancellationToken))
        {
            await Task.Delay(1000);
            Console.WriteLine($"Response Message:{resoult.ResponseStream.Current.Message}|Response Name:{resoult.ResponseStream.Current.Name}");
        }
    });
    


    await request;
    await resoult.RequestStream.CompleteAsync();
    await response;
}