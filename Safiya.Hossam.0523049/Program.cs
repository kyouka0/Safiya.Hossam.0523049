using Microsoft.EntityFrameworkCore;
using Safiya.Hossam._0523049.Db;
using Safiya.Hossam._0523049.Repository.CoachRepository;
using Safiya.Hossam._0523049.Repository.CompetitionRepository;
using Safiya.Hossam._0523049.Repository.GenericRepository;
using Safiya.Hossam._0523049.Repository.PlayerRepository;
using Safiya.Hossam._0523049.Repository.TeamRepository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<AppDbContext>(op => op.UseSqlServer(builder.Configuration.GetConnectionString("conn")));
builder.Services.AddScoped(typeof(IGeneric<>), typeof(GenericRepo<>));
builder.Services.AddScoped<ICoach,CoachRepo>();
builder.Services.AddScoped<ITeam, TeamRepo>();  
builder.Services.AddScoped<IPlayer, PlayerRepo>();
builder.Services.AddScoped<IComptetion, CompetitionRepo>();
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
