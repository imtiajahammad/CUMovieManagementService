using MovieManagement.DataAccess.Context;
using Microsoft.EntityFrameworkCore;
using MovieManagement.Domain.Repository;
using MovieManagement.DataAccess.Implementations;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


// Add Entity Framework
builder.Services.AddDbContext<MovieManagementDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("MovieConnection")));

builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();

/*to ignore the reference cycle of EFCore*/
builder.Services.AddMvc()
    .AddJsonOptions(x => x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

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

