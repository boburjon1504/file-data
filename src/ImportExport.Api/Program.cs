using ImportExport.Api.Interfaces;
using ImportExport.Api.Models;
using ImportExport.Api.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<ICSVService, CSVService>().AddSingleton<IInvoiceService, InvoiceService>()
    .AddMediatR(x => x.RegisterServicesFromAssemblies(typeof(Program).Assembly));
builder.Services.AddControllers();

builder
    .Services
    .AddEndpointsApiExplorer()
    .AddSwaggerGen();

var app = builder.Build();

app
    .UseSwagger()
    .UseSwaggerUI();
// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
