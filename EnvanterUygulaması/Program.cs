using EnvanterUygulamas�.Models;
using EnvanterUygulamas�.Repositories.Abstract;
using EnvanterUygulamas�.Repositories.Concrete;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Veritaban� ba�lant� ayar�n� al
var configuration = builder.Configuration;

// DbContext yap�land�rmas�n� ekle
builder.Services.AddDbContext<DataContext>(options =>
{
    var connectionString = configuration.GetConnectionString("MyDbContext");
    options.UseSqlServer(connectionString);
});

// Di�er hizmetleri ekle
builder.Services.AddControllersWithViews();

// DonanimRepository'yi IGenericRepository<Donanimlar> aray�z�ne enjekte et
builder.Services.AddScoped<IGenericRepository<Donanimlar>, DonanimRepository>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
