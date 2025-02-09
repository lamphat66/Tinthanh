
using Microsoft.Extensions.Configuration;
 
using System.IO;


namespace Tinthanh.ViewModel
{

    public static class Connect
    {
        public static string? GetConnectionString(string name = "TinthanhConnectionstring")
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
               .SetBasePath(Directory.GetCurrentDirectory())
               .AddJsonFile("appsettings.json")
               .Build();
            var connectionString = configuration.GetConnectionString("TinthanhDb");
            return connectionString;
        }
    }


}
