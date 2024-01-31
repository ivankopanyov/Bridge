var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<OperaDbContext>();
builder.Services.AddSingleton<IOperaService, OperaService>();

builder.Services
    .ConfigureWritable<OperaOptions>(builder.Configuration.GetSection(OperaOptions.SectionName));

builder.Services
    .AddHostedService<CheckOperaHandler>()
    .AddLogger()
    .AddEventBus()
    .Register<ReservationHandler, ReservationInfo>();

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
