var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddLogger()
    .AddFias(builder.Configuration)
    .AddHostedService<FiasStateHandler>()
    .AddEventBus()
    .RegisterStart<CheckInHandler, FiasGuestCheckIn, ReservationInfo>()
    .RegisterStart<CheckOutHandler, FiasGuestCheckOut, ReservationInfo>()
    .RegisterStart<ChangeHandler, FiasGuestChange, ReservationInfo>();

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
