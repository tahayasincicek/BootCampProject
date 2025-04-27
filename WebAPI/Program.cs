using Business.Abstract;
using Business.Concrete;
using Core.Repositories;
using Entities;
using Microsoft.EntityFrameworkCore;
using Infrastructure.Data;
using Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

// DbContext ekliyoruz
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseInMemoryDatabase("TestDb"));

// Dependency Injection
builder.Services.AddScoped<IUserService, UserManager>();
builder.Services.AddScoped<IUserRepository, EfUserRepository>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
