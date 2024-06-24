var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddCors()
    .AddTransient<ILogRepository, LogRepository>()
    .AddScoped<IServiceRepository, ServiceRepository>()
    .AddScoped<IEnvironmentRepository, EnvironmentRepository>()
    .AddScoped<ISearchArgsRepository, SearchArgsRepository>()
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
    .AddIdentity<User, Role>(options =>
    {
        options.Password.RequireDigit = false;
        options.Password.RequiredLength = 6;
        options.Password.RequireNonAlphanumeric = false;
        options.Password.RequireUppercase = false;
        options.Password.RequireLowercase = false;
    })
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

app.MapHub<LogHub>("/logs");
app.MapHub<ServiceHub>("/services");
app.MapHub<EnvironmentHub>("/environment");
app.MapHub<SearchArgsHub>("/searchArgs");
app.MapControllers();

app.Run();
