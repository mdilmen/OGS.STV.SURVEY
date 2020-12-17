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

namespace OGS.STV.SURVEY
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var hostbuilder = CreateHostBuilder(args);
            var host = hostbuilder.Build();
            RunSeeding(host);
            host.Run();
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
