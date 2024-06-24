var builder = Host.CreateApplicationBuilder(args);

builder.Services
    .AddRedis()
    .AddDefaultServices(hostName: "fiscal", hostId: 4,
        eventBusBuilder => eventBusBuilder
            .AddEventHandler<CheckHandler, Check>(options => options.HandlerName = "CHECK_DB"),
        serviceControlBuilder => serviceControlBuilder
            .AddTransient<IFiscalService, FiscalService, CheckDbOptions>(options => options.ServiceName = "CheckDB"));

var app = builder.Build();
app.Run();
