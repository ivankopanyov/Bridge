var builder = WebApplication.CreateBuilder(args);

var http1Port = int.TryParse(Environment.GetEnvironmentVariable("HTTP1_PORT"), out int http1)
    && http1 >= IPEndPoint.MinPort && http1 <= IPEndPoint.MaxPort ? http1 : 80;

var http2Port = int.TryParse(Environment.GetEnvironmentVariable("HTTP2_PORT"), out int http2)
    && http2 >= IPEndPoint.MinPort && http2 <= IPEndPoint.MaxPort ? http2 : 8080;

builder.WebHost.ConfigureKestrel(options => 
{
    options.ListenAnyIP(http1Port, listenOptions => listenOptions.Protocols = HttpProtocols.Http1);
    options.ListenAnyIP(http2Port, listenOptions => listenOptions.Protocols = HttpProtocols.Http2);
});

builder.Services.AddLogger();
builder.Services.AddServiceHost(options => options.Http2Port = http2Port);

builder.Services.AddScoped<IServiceRepository, ServiceRepository>();
builder.Services.AddHostedService<BridgeStartService>();

builder.Services
    .AddDbContext<BridgeDbContext>()
    .AddIdentity<User, Role>(options =>
    {
        options.Password.RequireDigit = false;
        options.Password.RequiredLength = 6;
        options.Password.RequireNonAlphanumeric = false;
        options.Password.RequireUppercase = false;
        options.Password.RequireLowercase = false;
    })
    .AddEntityFrameworkStores<BridgeDbContext>();

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
app.MapServiceHost<BridgeServiceHost>();

app.Run();
