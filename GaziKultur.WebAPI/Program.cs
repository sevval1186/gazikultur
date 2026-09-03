using GaziKultur.Data.Concrete.EntityFramework;
using Microsoft.EntityFrameworkCore;
using GaziKultur.Service.Abstract;
using GaziKultur.Service.Concrete.Manager;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddCors(options =>
{
    options.AddPolicy("GaziKulturFrontend", policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyMethod()
              .AllowAnyHeader();
    });
});

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<GaziKulturContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("GaziKulturDb"));
});

// Service katmanındaki interface'leri somut sınıflarla eşliyoruz (Dependency Injection).
builder.Services.AddScoped<IKutuphaneService, KutuphaneManager>();
builder.Services.AddScoped<IMuzeService, MuzeManager>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors("GaziKulturFrontend");
app.UseAuthorization();
app.MapControllers();

app.Run();
