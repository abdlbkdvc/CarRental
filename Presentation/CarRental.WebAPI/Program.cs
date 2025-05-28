using CarRental.Application.Interfaces;
using CarRental.Application.Services;
using CarRental.Persistence.Context;
using CarRental.Persistence.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// Add DbContext and Repository
builder.Services.AddScoped<CarRentalDbContext>();
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

//MediaTR Servis
builder.Services.AddApplicationService(builder.Configuration); // ✅ Uygulama servislerini ekle

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddEndpointsApiExplorer();   // ✅ Swagger için gerekli
builder.Services.AddSwaggerGen();             // ✅ Swagger için gerekli

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.MapGet("/", () => Results.Redirect("/swagger"));

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
