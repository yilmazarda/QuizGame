using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;
using QuizGameAPI.data;
using QuizGameAPI.models;
using QuizGameAPI.Repositories;
using QuizGameAPI.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IQuizService, QuizService>(); 
builder.Services.AddScoped<IGameService, GameService>(); 
builder.Services.AddScoped<IGameRepository, GameRepository>();
builder.Services.AddScoped<IQuizRepository, QuizRepository>();

builder.Services.AddControllers()
.AddJsonOptions(options =>
{
    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve;
    options.JsonSerializerOptions.MaxDepth = 64; // Optional: Increase depth if necessary
});

builder.Services.AddDbContext<QuizGameContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapControllers();

app.Run();