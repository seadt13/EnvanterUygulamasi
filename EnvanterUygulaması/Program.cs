using EnvanterUygulamasý.Models;
using EnvanterUygulamasý.Repositories.Abstract;
using EnvanterUygulamasý.Repositories.Concrete;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Veritabaný baðlantý ayarýný al
var configuration = builder.Configuration;

// DbContext yapýlandýrmasýný ekle
builder.Services.AddDbContext<DataContext>(options =>
{
    var connectionString = configuration.GetConnectionString("MyDbContext");
    options.UseSqlServer(connectionString);
});

// Diðer hizmetleri ekle
builder.Services.AddControllersWithViews();

// DonanimRepository'yi IGenericRepository<Donanimlar> arayüzüne enjekte et
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
