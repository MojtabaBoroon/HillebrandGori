using ShipmentApp.Application;
using ShipmentApp.Application.Abstraction;
using ShipmentApp.DataTransferring.Mapper;
using ShipmentApp.ExternalServices;
using ShipmentApp.ExternalServices.Abstraction;
using ShipmentApp.Persistence;
using ShipmentApp.Persistence.Abstractions;
using ShipmentApp.Persistence.DataAccessContext;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<IGetReadyDate, GetReadyDate>();
builder.Services.AddTransient<IShipmentsApiClient, ShipmentsApiClient>();
builder.Services.AddTransient<IShipmentRepository, ShipmentRepository>();
builder.Services.AddTransient<IGetAccessToken, GetAccessToken>();
builder.Services.AddTransient<HillebrandGoriDbContext>();
builder.Services.AddAutoMapper(typeof(ShipmentDtoMapper));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
public partial class Program { }