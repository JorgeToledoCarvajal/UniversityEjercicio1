using Microsoft.EntityFrameworkCore;
using UniversityEjercicio1.DataAccess;

var builder = WebApplication.CreateBuilder(args);

// 1. Conexión con BD
const string CONNECTIONNAME = "EjercicioDB";
var connectionstring = builder.Configuration.GetConnectionString(CONNECTIONNAME);

// 2. Añadir Contexto
builder.Services.AddDbContext<EjercicioDBContext>(options => options.UseSqlServer(connectionstring));

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
