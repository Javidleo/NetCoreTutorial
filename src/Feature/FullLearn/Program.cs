using FullLearn.MiddleWare;
using FullLearn.Option;
using FullLearn.Prestence;
using FullLearn.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.Configure<Config>(builder.Configuration.GetSection(nameof(Config)));
builder.Services.AddDbContext<Context>(option => option.UseSqlServer(builder.Configuration.GetConnectionString("Local")));
builder.Services.AddTransient<IDiServeses,DiServeses>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseMiddleware<ErrorHandlerMiddleWare>();


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
