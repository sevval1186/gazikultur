using GaziKultur.Data.Concrete.EntityFramework;
using GaziKultur.Service.Abstract;
using GaziKultur.Service.Concrete.Manager;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// MVC
builder.Services.AddControllersWithViews();

// Veritabaný baðlantýsý
builder.Services.AddDbContext<GaziKulturContext>(options =>
{
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("GaziKulturDb")
    );
});

// Repository kayýtlarý
builder.Services.AddScoped<EfMuzeRepository>();

// Service kayýtlarý
builder.Services.AddScoped<IMuzeService, MuzeManager>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();