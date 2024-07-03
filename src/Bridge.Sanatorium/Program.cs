const string N_SERVICE_BUS = "N_SERVICE_BUS";

var builder = Host.CreateApplicationBuilder(args);

builder.Services
    .AddDefaultServices(hostName: "sanatorium", hostId: 5,
        eventBusBuilder => eventBusBuilder
            .AddPostingEventHandler<PostingRequestHandler, PostingRequest>(options => options.HandlerName = N_SERVICE_BUS)
            .AddPostingEventHandler<PostingResponseHandler, PostResponseInfo>(options => options.HandlerName = N_SERVICE_BUS)
            .AddEventHandler<ReservationHandler, ReservationUpdateInfo>(options => options.HandlerName = N_SERVICE_BUS),
        serviceControlBuilder => serviceControlBuilder
            .AddSingleton<ISanatoriumService, SanatoriumService, ServiceBusOptions>(options => options.ServiceName = "NServiceBus"));

var app = builder.Build();
app.Run();
