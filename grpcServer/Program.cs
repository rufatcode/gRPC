using grpcInfoServer.Services;
using grpcMessageServer.Services;
using grpcServer.Services;
using grpcStreamServer.Services;
using grpcBiDirectioanlarStream.Services;
using grpcConnectionServer.Services;
using grpcFileServer.Services;

var builder = WebApplication.CreateBuilder(args);

// Additional configuration is required to successfully run gRPC on macOS.
// For instructions on how to configure Kestrel and gRPC clients on macOS, visit https://go.microsoft.com/fwlink/?linkid=2099682

// Add services to the container.
builder.Services.AddGrpc();

var app = builder.Build();
app.UseStaticFiles();
// Configure the HTTP request pipeline.

app.MapGrpcService<GreeterService>();
app.MapGrpcService<MessageService>();
app.MapGrpcService<InfoService>();
app.MapGrpcService<ServerStreamService>();
app.MapGrpcService<BiDirectionalService>();
app.MapGrpcService<ConnectionService>();
app.MapGrpcService<FileService>();
app.MapGet("/", () => "Communication with gRPC endpoints must be made through a gRPC client. To learn how to create a client, visit: https://go.microsoft.com/fwlink/?linkid=2086909");

app.Run();
