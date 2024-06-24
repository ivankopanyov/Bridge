var builder = Host.CreateApplicationBuilder(args);

builder.Services
    .AddMemoryCache()
    .AddDefaultServices(hostName: "fias", hostId: 2,
        eventBusBuilder => eventBusBuilder
            .AddReservationEventHandler<CheckInHandler, FiasGuestCheckIn>(options => options.HandlerName = "CHECK_IN")
            .AddReservationEventHandler<CheckOutHandler, FiasGuestCheckOut>(options => options.HandlerName = "CHECK_OUT")
            .AddReservationEventHandler<ChangeHandler, FiasGuestChange>(options => options.HandlerName = "CHANGE")
            .AddEventHandler<PostingHandler, PostRequestInfo>(options => options.HandlerName = "FIAS"),
        serviceControlBuilder => serviceControlBuilder
            .AddSingleton<IFiasService, FiasService, FiasServiceOptions>(options => options.ServiceName = "Fias"));

var app = builder.Build();
app.Run();
