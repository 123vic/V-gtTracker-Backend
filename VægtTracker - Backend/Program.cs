using Backend_Classes.Repositories;
using Backend_Classes.Interfaces;
using Backend_Classes.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddSingleton<IngrediensRepository>();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
        policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());
});

builder.Services.AddHttpClient<IOpenFoodFactsService, OpenFoodFactsService>(c =>
{
    c.BaseAddress = new Uri("https://dk.openfoodfacts.org/");
    c.DefaultRequestHeaders.UserAgent.ParseAdd("VaegtTracker/1.0 (Lucas4e12345@gmail.com)");
});

var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseCors("AllowAll");

app.UseAuthorization();

app.MapControllers();

app.Run();
