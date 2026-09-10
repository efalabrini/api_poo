using api_poo.Interfaces;
using Microsoft.AspNetCore.Mvc;
using api_poo.Entities;
using api_poo.Models;
using api_poo.Data; 

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
builder.Services.AddOpenApi();

// Inyección de dependencias: cuando una clase solicite IBankAccountRepository,
// el contenedor creará y entregará un BankAccountRepository.
// AddScoped significa que se usa una instancia por cada petición HTTP.
builder.Services.AddScoped<IBankAccountRepository, BankAccountRepository>();


var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}


app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();


app.Run();