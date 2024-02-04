var builder = WebApplication.CreateBuilder(args);

var http1Port = int.TryParse(Environment.GetEnvironmentVariable("HTTP1_PORT"), out int http1)
    && http1 >= IPEndPoint.MinPort && http1 <= IPEndPoint.MaxPort ? http1 : 80;

var http2Port = int.TryParse(Environment.GetEnvironmentVariable("HTTP2_PORT"), out int http2)
    && http2 >= IPEndPoint.MinPort && http1 <= IPEndPoint.MaxPort ? http2 : 8080;

builder.WebHost.ConfigureKestrel(options => 
{
    options.Listen(IPAddress.Any, http1Port, listenOptions => listenOptions.Protocols = HttpProtocols.Http1);
    options.Listen(IPAddress.Any, http2Port, listenOptions => listenOptions.Protocols = HttpProtocols.Http2);
});

builder.Services
    .AddLogger()
    .AddFias()
    .AddHostedService<FiasStateHandler>();

builder.Services.AddEventBus()
    .Register<CheckInHandler, FiasGuestCheckIn>()
    .Register<CheckOutHandler, FiasGuestCheckOut>()
    .Register<ChangeHandler, FiasGuestChange>();

builder.Services.AddServiceHostClinet(optios =>
{
    optios.Host = Environment.GetEnvironmentVariable("HOST") ?? "fias";
    optios.ServiceHost = $"http://{Environment.GetEnvironmentVariable("HOST_API") ?? "hostapi"}:{http2Port}";
}).Register<FiasServiceNode>(options =>
{
    options.Name = "Fias";
    options.UseRestart = true;
});

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

app.Run();
