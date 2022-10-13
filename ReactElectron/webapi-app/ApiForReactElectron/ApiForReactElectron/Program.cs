using ApiForReactElectron.Data;
using ApiForReactElectron.Repositories;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;

// Add services to the container.

services.AddControllers();
services.AddRouting(options => options.LowercaseUrls = true);
services.AddDbContext<ApplicationDbContext>(options => options.UseInMemoryDatabase("InMemory"));
services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
services.AddCors(options =>
    options.AddPolicy(name: "DefaultPolicy", options => options.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader()));
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
services.AddEndpointsApiExplorer();
services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("DefaultPolicy");

app.UseAuthorization();

app.MapControllers();

app.Run();