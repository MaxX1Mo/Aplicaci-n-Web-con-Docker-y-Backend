using System;
using Microsoft.EntityFrameworkCore;
using ClientRequestsAPI.Data;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.WebHost.UseUrls("http://*:80"); //Esto configura la API para escuchar en el puerto 80 dentro del contenedor, mientras Docker lo expone en el puerto 5024 en el host

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseMySql(builder.Configuration.GetConnectionString("conexion"),
                     ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("conexion"))));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(options =>
{
    options.AddPolicy("NewPolicy", app =>
    {
        app.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
    });
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseRouting();
app.UseCors("NewPolicy");
app.UseAuthorization();

app.MapControllers();

app.Run();
