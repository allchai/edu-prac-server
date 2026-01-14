using server.Data;
using server.Middlewares;
using server.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

DotNetEnv.Env.Load();

var connectionsString = $"Host={Environment.GetEnvironmentVariable("DB_HOST")};" +
                        $"Port={Environment.GetEnvironmentVariable("DB_PORT")};" +
                        $"Database={Environment.GetEnvironmentVariable("DB_NAME")};" +
                        $"Username={Environment.GetEnvironmentVariable("DB_USER")};" +
                        $"Password={Environment.GetEnvironmentVariable("DB_PASSWORD")}";

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(connectionsString));

builder.Services.AddScoped<IScheduleService, ScheduleService>();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
// For some reason I had to install Swashbuckle.AspNetCore to make this work
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseMiddleware<ExceptionMiddleware>();

app.UseAuthorization();
app.UseRouting();

app.MapControllers();

app.Run();
