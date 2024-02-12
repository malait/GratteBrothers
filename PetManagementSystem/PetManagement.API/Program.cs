using Microsoft.EntityFrameworkCore;
using PetManagement.Data;
using PetManagement.DataAccess.Implementation;
using PetManagement.DataAccess.Interface;
using PetManagement.Service.Implementation;
using PetManagement.Service.Interface;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Dependency Injection

//Data Access layer
builder.Services.AddScoped<IPersonCRUD, PersonCRUD>();
builder.Services.AddScoped<ISpeciesCRUD,SpeciesCRUD>();
builder.Services.AddScoped<IPetOwnerCRUD,PetOwnerCRUD>();

//Service layer
builder.Services.AddScoped<IPersonsGetter,PersonsGetter>();
builder.Services.AddScoped<ISpeciesGetter,SpeciesGetter>();
builder.Services.AddScoped<IPetOwnerGetter,PetOwnerGetter>();
builder.Services.AddScoped<IPetOwnerAdder,PetOwnerAdder>();
builder.Services.AddScoped<IPetNameUpdater,PetNameUpdater>();

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
