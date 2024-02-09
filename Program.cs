using Microsoft.EntityFrameworkCore;
using RentaKranApp.Model.Context;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

string connetion = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<RentaKranDBContext>(options => options.UseSqlServer(connetion));

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
