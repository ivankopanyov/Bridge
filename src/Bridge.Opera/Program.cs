var builder = WebApplication.CreateBuilder(args);

var http2Port = int.TryParse(Environment.GetEnvironmentVariable("HTTP2_PORT"), out int http2)
    && http2 >= IPEndPoint.MinPort && http2 <= IPEndPoint.MaxPort ? http2 : 8080;

builder.WebHost.ConfigureKestrel(options => options.ListenAnyIP(http2Port, listenOptions => listenOptions.Protocols = HttpProtocols.Http2));

builder.Services.AddDbContext<OperaDbContext>();

builder.Services
    .AddHostedService<CheckOperaHandler>()
    .AddLogger();

builder.Services.AddServiceControl(optios =>
{
    optios.Host = Environment.GetEnvironmentVariable("HOST") ?? "opera";
    optios.ServiceHost = $"http://{Environment.GetEnvironmentVariable("HOST_API") ?? "hostapi"}:{http2Port}";
})
.AddService<OperaServiceNode, OperaOptions>(options => options.Name = "Oracle")
.AddEventBus(builder => builder.AddHandler<ReservationHandler, ReservationInfo>());

var app = builder.Build();

app.MapServiceControl();

app.Run();
