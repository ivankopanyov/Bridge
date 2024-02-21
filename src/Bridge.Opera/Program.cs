var builder = WebApplication.CreateBuilder(args);

var http2Port = int.TryParse(Environment.GetEnvironmentVariable("HTTP2_PORT"), out int http2)
    && http2 >= IPEndPoint.MinPort && http2 <= IPEndPoint.MaxPort ? http2 : 8080;

builder.WebHost.ConfigureKestrel(options => options.ListenAnyIP(http2Port, listenOptions => listenOptions.Protocols = HttpProtocols.Http2));

builder.Services.AddDbContext<OperaDbContext>();

builder.Services
    .AddHostedService<CheckOperaHandler>();

var loggerConfiguration = new LoggerConfiguration()
    .WriteTo.Console()
    .WriteTo.File("logs/all_logs_.log", rollingInterval: RollingInterval.Day);

builder.Services.AddServiceControl(options =>
{
    options.Host = Environment.GetEnvironmentVariable("HOST") ?? "opera";
    options.ServiceHost = $"http://{Environment.GetEnvironmentVariable("HOST_API") ?? "hostapi"}:{http2Port}";
    options.LoggerConfiguration = loggerConfiguration;
})
.AddService<OperaServiceNode, OperaOptions>(options => options.Name = "Oracle")
.AddEventBus(builder => builder
    .AddLogger(loggerConfiguration)
    .AddHandler<ReservationHandler, ReservationInfo>());

builder.Services.AddSerilog(loggerConfiguration.CreateLogger());

var app = builder.Build();

app.MapServiceControl();

app.Run();
