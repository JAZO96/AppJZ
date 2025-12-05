using AppJZ.Models;
using Microsoft.EntityFrameworkCore;

using Microsoft.AspNetCore.Identity;
using AppJZ.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

var conString = builder.Configuration.GetConnectionString("conexion") ??
    throw new InvalidOperationException("Connection string 'conexion' not found.");

// === CONTEXTO DE TU BD EXISTENTE ===
builder.Services.AddDbContext<AulalinkContext>(options =>
    options.UseMySql(conString, ServerVersion.AutoDetect(conString)));

// === CONTEXTO PARA IDENTITY ===
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseMySql(conString, ServerVersion.AutoDetect(conString)));

// === CONFIGURACIÓN DE IDENTITY ===
// MUY IMPORTANTE: usar el ApplicationUser correcto (el de AppJZ.Data)
builder.Services.AddIdentity<AppJZ.Data.ApplicationUser, IdentityRole>(options =>
{
    options.SignIn.RequireConfirmedAccount = false;

    // Contraseña relajada
    options.Password.RequireDigit = false;
    options.Password.RequireLowercase = false;
    options.Password.RequireUppercase = false;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequiredLength = 6;

    options.User.RequireUniqueEmail = true;

    // Bloqueo
    options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
    options.Lockout.MaxFailedAccessAttempts = 5;
})
.AddEntityFrameworkStores<ApplicationDbContext>()
.AddDefaultTokenProviders()
.AddDefaultUI();

// === COOKIES DE AUTENTICACIÓN ===
builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = "/Identity/Account/Login";
    options.LogoutPath = "/Identity/Account/Logout";
    options.AccessDeniedPath = "/Identity/Account/AccessDenied";
    options.ExpireTimeSpan = TimeSpan.FromHours(8);
    options.SlidingExpiration = true;
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

// Identity UI
app.MapRazorPages();

// MVC
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
