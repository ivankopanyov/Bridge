var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddCors()
    .AddRepositories()
    .AddHostedService<BridgeStartService>()
    .AddRedis()
    .AddDefaultServices(hostName: "hostapi", hostId: 1,
        eventBusBuilder => eventBusBuilder
            .AddLogHandler<UpdateHandler>()
            .AddLogHandler<ElasticSearchHandler>(),
        serviceControlBuilder => serviceControlBuilder
            .AddTransient<IElasticSearchService, ElasticSearchService, ElasticSearchOptions>(options => options.ServiceName = "ElasticSearch")
            .AddServiceController());

builder.Services
    .AddDbContext<BridgeDbContext>()
    .AddIdentity<User, Role>(options => builder.Configuration.Bind(nameof(PasswordOptions), options.Password))
    .AddEntityFrameworkStores<BridgeDbContext>();

builder.Services.AddSignalR();

builder.Services
    .AddControllers()
    .AddNewtonsoftJson(options => options.SerializerSettings.ContractResolver = new DescriptionContractResolver())
    .ConfigureApiBehaviorOptions(options => options.InvalidModelStateResponseFactory = context =>
        new BadRequestObjectResult(string.Join(' ', context.ModelState.Select(entry => string.Join(' ', entry.Value?.Errors.Select(error => error.ErrorMessage) ?? Array.Empty<string>())))));

builder.Services
    .AddEndpointsApiExplorer()
    .AddSwaggerGen();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    using var context = scope.ServiceProvider.GetService<BridgeDbContext>()!;
    await context.Database.MigrateAsync();
}

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(builder => builder
    .AllowAnyMethod()
    .AllowAnyHeader()
    .SetIsOriginAllowed(origin => true)
    .AllowCredentials());

app.UseAuthorization();

app
    .MapHubs()
    .MapControllers();

app.Run();
