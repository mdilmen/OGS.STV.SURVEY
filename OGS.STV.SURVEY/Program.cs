using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using OGS.STV.SURVEY.Data;
using Serilog;
using Serilog.Events;
using Serilog.Formatting.Compact;
using Serilog.Formatting.Json;

namespace OGS.STV.SURVEY
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Log.Logger = new LoggerConfiguration()
                .Enrich.FromLogContext()
                .MinimumLevel.Override("Microsoft.AspNetCore", LogEventLevel.Warning)
                .MinimumLevel.Override("Microsoft", LogEventLevel.Warning)
                .MinimumLevel.Override("System.Net.Http.HttpClient", LogEventLevel.Warning)
                .WriteTo.File(new RenderedCompactJsonFormatter(), @"c:/temp/logs/STL_Survey.json")
                .WriteTo.Seq("http://localhost:5341")


                .CreateLogger();
            try
            {
                Log.Information("Starting up");
                var hostbuilder = CreateHostBuilder(args);
                var host = hostbuilder.Build();
                RunSeeding(host);
                host.Run();
            }
            catch (Exception ex)
            {
                Log.Fatal(ex, "Application start-up failed");
            }
            finally
            {
                Log.CloseAndFlush();
            }
        }
        private static void RunSeeding(IHost host)
        {
            var scopeFactory = host.Services.GetService<IServiceScopeFactory>();
            using (var scope = scopeFactory.CreateScope())
            {
                var seeder = scope.ServiceProvider.GetService<SurveySeeder>();
                seeder.SeedAsync().Wait();
            }
        }
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .UseSerilog()
                //.ConfigureLogging((hostingContext, logging) =>
                //{
                //    logging.AddConfiguration(hostingContext.Configuration.GetSection("SeriLog"));
                //    logging.AddFilter("System", LogLevel.Warning);
                //})
                .ConfigureAppConfiguration(SetupConfiguration)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
        private static void SetupConfiguration(HostBuilderContext ctx, IConfigurationBuilder builder)
        {
            //throw new NotImplementedException();
            builder.Sources.Clear();
            builder.AddJsonFile("config.json", false, true);
            builder.AddEnvironmentVariables();
        }
    }
}
