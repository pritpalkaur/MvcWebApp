﻿using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using webapitaskup.Models;
using WebApi.Business.Interface;
using WebApi.Business.Implementations;
using WebApi.Data.Interface;
using WebApi.Data.Implementations;
using WebApi.Data;
using WebApi.Exceptions.Service;
using Microsoft.Extensions.Logging;
using Serilog.Extensions.Logging.File;
using Serilog;
using WebApi.Exceptions.Data;
using WebApi.Data.Implementations;
public class Startup
{
    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    // This method gets called by the runtime. Use this method to add services to the container.
    public void ConfigureServices(IServiceCollection services)
    {
        var jwtSettings = Configuration.GetSection("JwtSettings");
        var secretKey = jwtSettings["SecretKey"];

        services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            .AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = jwtSettings["Issuer"],
                    ValidAudience = jwtSettings["Audience"],
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey))
                };
            });

        services.AddControllers();

<<<<<<< HEAD:Startup.cs
        services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
<<<<<<< HEAD
        services.AddCors(options =>
        {
            options.AddPolicy("AllowReactApp",
                builder =>
                {
                    builder.WithOrigins("http://localhost:3000") // React app URL
                           .AllowAnyMethod()
                           .AllowAnyHeader()
                           .AllowCredentials(); // Allow credentials if using cookies or authentication tokens
                });
=======
        //services.AddCors(options =>
        //{
        //    options.AddPolicy("AllowReactApp",
        //        builder =>
        //        {
        //            builder.WithOrigins("http://localhost:3000") // React app URL
        //                   .AllowAnyMethod()
        //                   .AllowAnyHeader()
        //                   .AllowCredentials(); // Allow credentials if using cookies or authentication tokens
        //        });
        //});
=======
     

        services.AddDbContext<WebApiApplicationDbContext>(options =>
           options.UseSqlServer(Configuration.GetConnectionString("WebApiApplicationDbContextconstrg")));
        services.AddDbContext<LoggingDbContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("ExContextconstrg")));

        //------------------------project dependency--------------------------------------------
        services.AddScoped<IProductBusiness, ProductBusiness>();
        services.AddScoped<IProductDatabase, ProductDatabase>();
        //------------------------report dependency--------------------------------------------
        services.AddScoped<IReportBusiness, ReportBusiness>();
        services.AddScoped<IReportDatabase, ReportDatabase>();
        //------------------------error logging-------------------------------------------------
        services.AddScoped<ILoggingService, LoggingService>(); // Custom service to log to the database
        //-------------------------------------------------------------------------------------------------
        services.AddSingleton<IDbConnectionFactory, SqlDbConnectionFactory>();

        // Configure logging providers (Console and/or File)
        services.AddLogging(loggingBuilder =>
        {
            loggingBuilder.AddConsole();
            //loggingBuilder.AddFilter("Logs/app.log"); // Requires a third-party package like Serilog.Extensions.Logging.File
        });
>>>>>>> main:WebApi/Startup.cs

        services.AddCors(options =>
        {
            options.AddPolicy("AllowSpecificOrigin",
                builder => builder
                    .WithOrigins("http://localhost:4200") // Angular frontend URL
                    .AllowAnyHeader()
                    .AllowAnyMethod());
>>>>>>> main
        });

    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }
        else
        {
            app.UseExceptionHandler("/Home/Error");
            app.UseHsts();
        }
        app.UseSerilogRequestLogging(); // Enable Serilog request logging
        app.UseHttpsRedirection();
        app.UseStaticFiles();
        app.UseRouting();
        app.UseAuthorization();
<<<<<<< HEAD
        app.UseCors("AllowReactApp"); // Add the CORS middleware here

=======
        //app.UseCors("AllowReactApp"); // Add the CORS middleware here
        // Use CORS policy

        app.UseCors("AllowSpecificOrigin"); // Apply the CORS policy
>>>>>>> main
        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
        });
    }
    
}


//public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
//{
//    if (env.IsDevelopment())
//    {
//        app.UseDeveloperExceptionPage();
//    }
//    else
//    {
//        app.UseExceptionHandler("/Home/Error");
//        app.UseHsts();
//    }

//    app.UseHttpsRedirection();
//    app.UseStaticFiles();

//    app.UseRouting();

//    app.UseCors("AllowReactApp");

//    app.UseAuthorization();

//    app.UseEndpoints(endpoints =>
//    {
//        endpoints.MapControllers();
//    });
//}