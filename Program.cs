using Microsoft.EntityFrameworkCore;
using Moment_3.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<ApplicationDbContext>(options =>

     options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"))

    );


// Dynamically configure Kestrel to bind to the first non-loopback IPv4 address on port 1010
//builder.WebHost.ConfigureKestrel(serverOptions =>
//{
//    var ipv4Address = Dns.GetHostEntry(Dns.GetHostName())
//        .AddressList
//        .FirstOrDefault(ip => ip.AddressFamily == AddressFamily.InterNetwork);

//    if (ipv4Address != null)
//    {
//        serverOptions.Listen(ipv4Address, 1010);
//    }
//    else
//    {
//        Fallback to loopback if no non - loopback IPv4 address is found
//       serverOptions.Listen(IPAddress.Loopback, 1010);
//    }
//});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
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