using AspNetElectron.Data;
using AspNetElectron.HostedServices;
using AspNetElectron.Repositories;
using ElectronNET.API;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var webHost = builder.WebHost;
var services = builder.Services;
var launchProfile = builder.Configuration.GetValue<string>("ASPNETCORE_PROFILE");

services.AddDbContext<ApplicationDbContext>(options => options.UseInMemoryDatabase("InMemory"));
services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
services.AddControllersWithViews();
services.AddRouting(options => options.LowercaseUrls = true);

if (launchProfile is not null && launchProfile != "Kestrel.Web")
{
    webHost.UseElectron(args);

    services.AddElectron();
    services.AddHostedService<ElectronHostedService>();
}

var app = builder.Build();

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Messages}/{action=GetAllMessages}");
app.Run();