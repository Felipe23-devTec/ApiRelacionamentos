using ApiRelacionamentos.Repository.DataContext;
using ApiRelacionamentos.Repository.Repository.RepositoryContract;
using ApiRelacionamentos.Repository.Repository.RepositoryImplementacion;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

//config context
builder.Services.AddEntityFrameworkSqlServer()
                .AddDbContext<Context>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DataBase")));
// Add services to the container.
builder.Services.AddScoped<IITemRepository, ItemRepository>();
builder.Services.AddScoped<IClienteRepository, ClienteRepository>();

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
