var builder = WebApplication.CreateBuilder(args);

var http2Port = int.TryParse(Environment.GetEnvironmentVariable("HTTP2_PORT"), out int http2)
    && http2 >= IPEndPoint.MinPort && http2 <= IPEndPoint.MaxPort ? http2 : 8080;

builder.WebHost.ConfigureKestrel(options => options.ListenAnyIP(http2Port, listenOptions => listenOptions.Protocols = HttpProtocols.Http2));

builder.Services
    .AddLogger()
    .AddEventBus()
    .Register<ReservationHandler, ReservationUpdatedMessage>();

builder.Services.AddServiceControl(optios =>
{
    optios.Host = Environment.GetEnvironmentVariable("HOST") ?? "sanatorium";
    optios.ServiceHost = $"http://{Environment.GetEnvironmentVariable("HOST_API") ?? "hostapi"}:{http2Port}";
}).Register<ServiceBusServiceNode, ServiceBusOptions>(options => options.Name = "NServiceBus");

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
app.MapServiceControl();

app.Run();
