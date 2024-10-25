using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using EjercicioApi.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<EjercicioApiContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("EjercicioApiContext") ?? throw new InvalidOperationException("Connection string 'EjercicioApiContext' not found.")));

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
