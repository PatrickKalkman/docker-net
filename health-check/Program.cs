using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace health_check
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .AddEnvironmentVariables()
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}

// var configuration = new ConfigurationBuilder()
//   .AddJsonFile("appsettings.json") // Duplicate == Json1
//   .AddJsonFile($"appsettings.{env.EnvironmentName}.json") // Duplicate == Json1
//   .AddEnvironmentVariables() // Duplicate == Environment
//   .Build();
