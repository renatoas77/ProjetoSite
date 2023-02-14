using FighteR_PG.Context;
using FighteR_PG.Models;
using FighteR_PG.Repositories.IRepositories;
using FighteR_PG.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using FighteR_PG.Services.IServices;
using FighteR_PG.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<AppDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddIdentity<User, IdentityRole>()
                .AddEntityFrameworkStores<AppDbContext>()
                .AddDefaultTokenProviders();

builder.Services.Configure<IdentityOptions>(options =>
{
    options.Password.RequireDigit = false;
    options.Password.RequireLowercase = false;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireUppercase = false;
    options.Password.RequiredLength = 6;
    options.Password.RequiredUniqueChars = 1;
});

builder.Services.AddTransient<ICharacterRepository, CharacterRepository>();
builder.Services.AddTransient<IBossRepository, BossRepository>();
builder.Services.AddTransient<IArchetypesRepository, ArchetypesRepository>();
builder.Services.AddScoped<ISeedRoleUser, SeedRoleUser>();

builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("Admin", politica =>
    {
        politica.RequireRole("Admin");
    });

});

builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
builder.Services.AddScoped(sp => Selection.GetSelection(sp));

builder.Services.AddMemoryCache();
builder.Services.AddSession();


var app = builder.Build();

using(var serviceScope = app.Services.CreateScope())
{
    var services = serviceScope.ServiceProvider;

    var myService = services.GetRequiredService<ISeedRoleUser>();
    myService.SeedRoles();
    myService.SeedUsers();
}

// Configure the HTTP request pipeline.
if(!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseSession();

app.UseAuthentication();
app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
      name: "areas",
      pattern: "{area:exists}/{controller=AdminHome}/{action=Index}/{id?}"
    );

    endpoints.MapControllerRoute(
      name: "arquetypesFilter",
      pattern: "Character/{action}/{arquetipo?}",
      defaults: new { Controller = "Character", action = "List" });

    endpoints.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
});

app.Run();
