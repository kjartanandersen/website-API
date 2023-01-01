using System.Security.Cryptography;

using API.Models;
using API.Services;

var builder = WebApplication.CreateBuilder(args);

// Authentication
// var rsaKey = RSA.Create();

// rsaKey.ImportRSAPrivateKey(File.ReadAllBytes("key"), out _);

// builder.Services.AddAuthentication()
//     .AddJwtBearer("jwt", o => {

//     });

// Add MongoDB connection
builder.Services.Configure<MongoDBSettings>
(builder.Configuration.GetSection("MongoDB"));

// DI
builder.Services.AddSingleton<ProfileService>();

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(p => p.AddPolicy("corspolicy", build =>
{
    build.WithOrigins("http://localhost:3000").AllowAnyMethod().AllowAnyHeader();
}));

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();
// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{

//}

app.UseCors("corspolicy");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
