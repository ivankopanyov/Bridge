var builder = Host.CreateApplicationBuilder(args);

builder.Services
    .AddRedis()
    .AddDefaultServices(hostName: "telegram", hostId: 6,
        eventBusBuilder => eventBusBuilder
            .AddLogHandler<TelegramMessageHandler>(),
        serviceControlBuilder => serviceControlBuilder
            .AddScoped<ITelegramBotService, TelegramBotService, TelegramBotOptions>(options => options.ServiceName = "TelegramBot"));

var app = builder.Build();
app.Run();
