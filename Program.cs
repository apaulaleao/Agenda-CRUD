using Agenda.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

//pra usar banco de dados em memoria. encerrou, zera tudo contexto de desenvolvimento. 
//builder.Services.AddDbContext<AgendaContext>(opt => opt.UseInMemoryDatabase("Agenda"));
//builder.Services.AddDbContext<AgendaContext>(opt => opt.UseSqlServer(@"Server=(LocalDb)\MSSQLLocalDB;Database=Agenda;User Id=root;Password=123456"));
builder.Services.AddDbContext<AgendaContext>(opt => opt.UseSqlServer(@"Server=DESKTOP-6HQM0TK\SQLEXPRESS01;Database=agenda;User Id=root;Password=123456"));


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
