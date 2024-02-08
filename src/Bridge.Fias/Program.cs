var builder = WebApplication.CreateBuilder(args);

var http2Port = int.TryParse(Environment.GetEnvironmentVariable("HTTP2_PORT"), out int http2)
    && http2 >= IPEndPoint.MinPort && http2 <= IPEndPoint.MaxPort ? http2 : 8080;

builder.WebHost.ConfigureKestrel(options => options.ListenAnyIP(http2Port, listenOptions => listenOptions.Protocols = HttpProtocols.Http2));

builder.Services
    .AddLogger()
    .AddFias()
    .AddHostedService<FiasStateHandler>();

builder.Services.AddServiceControl(optios =>
{
    optios.Host = Environment.GetEnvironmentVariable("HOST") ?? "fias";
    optios.ServiceHost = $"http://{Environment.GetEnvironmentVariable("HOST_API") ?? "hostapi"}:{http2Port}";
})
.AddService<FiasServiceNode, FiasServiceOptions>(options => options.Name = "Fias")
.AddEventBus(builder => builder
    .AddHandler<CheckInHandler, FiasGuestCheckIn>()
    .AddHandler<CheckOutHandler, FiasGuestCheckOut>()
    .AddHandler<ChangeHandler, FiasGuestChange>());

var app = builder.Build();

app.MapServiceControl();

app.Run();
