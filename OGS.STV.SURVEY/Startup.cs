using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using OGS.STV.SURVEY.Data;
using OGS.STV.SURVEY.Services;

namespace OGS.STV.SURVEY
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        private readonly IConfiguration _config;

        public Startup(IConfiguration config)
        {
            _config = config;
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddHttpClient<ValidationHttpClient>();
            services.AddHttpClient<MailHttpClient>();
            services.AddScoped<IMailService, MailService>();
            services.AddScoped<IReportService, ReportService>();
            services.AddTransient<SurveySeeder>();
            services.AddScoped<ISurveyRepository, SurveyRepository>();
            services.AddDbContext<SurveyDbContext>(cfg =>
            {
                cfg.UseSqlServer(_config.GetConnectionString("SurveyConnectionString"));
            });
            services.AddDefaultIdentity<IdentityUser>(cfg =>
            {
                cfg.User.RequireUniqueEmail = true;
            })                
                .AddEntityFrameworkStores<SurveyDbContext>();
            services.AddControllersWithViews()
                .AddRazorRuntimeCompilation()
                .SetCompatibilityVersion(CompatibilityVersion.Version_3_0);
            services.AddRazorPages();
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseExceptionHandler("/App/Error");
            app.UseHsts();

            // CultureInfo cultureInfo = new CultureInfo("tr");
            var supportedCultures = new[] { "tr-TR" };
            var localizationOptions = new RequestLocalizationOptions().SetDefaultCulture(supportedCultures[0])
                .AddSupportedCultures(supportedCultures)
                .AddSupportedUICultures(supportedCultures);

            app.UseRequestLocalization(localizationOptions);


            app.UseStaticFiles();
            //app.UseNodeModules();
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseEndpoints(cfg =>
            {
                cfg.MapControllerRoute("Fallback",
                    "{controller}/{action}/{id?}",
                    new { controller = "App", action = "Index" });
                cfg.MapRazorPages();
            });
        }
    }
}
