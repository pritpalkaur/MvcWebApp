using Microsoft.EntityFrameworkCore;
using MVC.Business.Implementations;
using MVC.Business.Interface;
using MVC.Data;
using MVC.Data.Implementations;
using MVC.Data.Interface;
using MVC.Exceptions.Data;
using MVC.Exceptions.Service;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Register services
        builder.Services.AddControllersWithViews();
        builder.Services.AddAuthorization(); // Add this line

        // Register DbContexts
        builder.Services.AddDbContext<MVCApplicationDbContext>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("MVCApplicationDbContextconstrg")));
        builder.Services.AddDbContext<LoggingDbContext>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("LoggingDbContextconstrg"))); // Register LoggingDbContext

        // Register other services
        builder.Services.AddScoped<IDbConnectionFactory, SqlDbConnectionFactory>();
        //---------------------product----------------------------
        builder.Services.AddScoped<IProductDatabase, ProductDatabase>();
        builder.Services.AddScoped<IProductBusiness, ProductBusiness>();
        //----------------------Reports----------------------------------------
        builder.Services.AddScoped<IReportBusiness,ReportBusiness>();
        builder.Services.AddScoped<IReportDatabase, ReportDatabase>();

        builder.Services.AddScoped<ILoggingService, LoggingService>(); // Add this line
        builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

        var app = builder.Build();

        // Configure the HTTP request pipeline
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

        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}");

        app.Run();
    }
}


