var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddLogger()
    .AddFias(builder.Configuration)
    .AddHostedService<FiasStateHandler>()
    .AddEventBus()
    .Register<CheckInHandler, FiasGuestCheckIn>()
    .Register<CheckOutHandler, FiasGuestCheckOut>()
    .Register<ChangeHandler, FiasGuestChange>();

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

app.Run();
