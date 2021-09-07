using EvenementApi.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EvenementApi
{
    public class Program
    {
        //public static void Main(string[] args)
        //{
        //    CreateHostBuilder(args).Build().Run();
        //}

        //public static IHostBuilder CreateHostBuilder(string[] args) =>
        //    Host.CreateDefaultBuilder(args)
        //        .ConfigureWebHostDefaults(webBuilder =>
        //        {
        //            webBuilder.UseStartup<Startup>();
        //        });

        public static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();
            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                // var context = services.GetRequiredService<ApplicationDbContext>();
                //context.Database.EnsureDeleted();
                // context.Database.Migrate();
                //  dotnet user-secrets set "AdminPw" "LexiconNA21!"
                //seeda andvandare
                /**
                 * secret json till localt på min dator
                 * Via terminal: PS C:\Users\Elev\mamery\GymBooking\GymBooking15.Web> dotnet user-secrets set "AdminPw" "LexiconNA21!"
                   Successfully saved AdminPw = LexiconNA21! to the secret store.
                 Via Visual studio manually: Du can also set the secret using 
                right click on the project -> manage user secret
                 */
                //plukka ut min configuration
                //  var config = services.GetRequiredService<IConfiguration>();
                //  var adminPW = config["AdminPW"];
                try
                {
                    SeeData.InitializeAsync(services).Wait();

                }
                catch (Exception ex)
                {
                   
                    var logger = services.GetRequiredService<ILogger<Program>>();
                    logger.LogError(ex.Message, "Seed failed");
                    throw;
                }
                //The responsibility of the ILogger interface is to write a log message

            }


            host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
