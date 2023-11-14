using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MVCDemoRepo.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<MVCDemoRepoContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("MVCDemoRepoContext") ?? throw new InvalidOperationException("Connection string 'MVCDemoRepoContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

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
    //controllernamnController/methodNamn (index tas om inget s�gs) / parameter om n�n anges
app.Run();
