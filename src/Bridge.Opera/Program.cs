var builder = Host.CreateApplicationBuilder(args);

builder.Services.AddDefaultServices(hostName: "opera", hostId: 3,
    eventBusBuilder => eventBusBuilder
        .AddEventHandler<ReservationHandler, ReservationInfo>(options => options.HandlerName = "OPERA_DB"),
    serviceControlBuilder => serviceControlBuilder
        .AddTransient<IOperaService, OperaService, OperaOptions>(options => options.ServiceName = "Oracle"));

var app = builder.Build();
app.Run();
