using LearnFramework.Interface;
using LearnFramework.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//Injection configuration
builder.Services.Configure<AppSettingTest>(builder.Configuration.GetSection("Appsetting"));
//No constructor injection
//builder.Services.AddScoped<IInjectionWork, InjectionWork>();

//With constructor injection
var app = builder.Configuration.GetSection("AppsettingTest").Get<AppSettingTest>();
builder.Services.AddScoped<IInjectionWork, InjectionWork>(c => new InjectionWork(app));


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
