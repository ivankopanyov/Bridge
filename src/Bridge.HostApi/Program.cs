using Bridge.HostApi.Services;

var builder = WebApplication.CreateBuilder(args);

builder.WebHost.ConfigureKestrel(options => options.Listen(IPAddress.Any, 8080, ListenOptions =>
{
    ListenOptions.Protocols = HttpProtocols.Http2;
}));

builder.Services.AddLogger();
builder.Services.AddGrpc();
builder.Services.AddServiceControlClient();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();
app.MapGrpcService<BridgeServiceHost>();

app.Run();
