using Microsoft.EntityFrameworkCore;
using ServicesAdministrationMs.BusinessLayer.Services;
using ServicesAdministrationMs.Database;
using ServicesAdministrationMs.Database.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ServiceAdministrationContext>(options => options.UseNpgsql(""));
builder.Services.AddScoped<IGenericRepository, GenericRepository>();
builder.Services.AddScoped<IServiceAdministrationService, ServiceAdministrationService>();

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
