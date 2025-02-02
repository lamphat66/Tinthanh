
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Tinthanh.Data.EF
{
    public class TinthanhDbContextFactory : IDesignTimeDbContextFactory<TinthanhDBContext>
    {
        public TinthanhDBContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("TinthanhDb");

            var optionsBuilder = new DbContextOptionsBuilder<TinthanhDBContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new TinthanhDBContext(optionsBuilder.Options);
        }
    }
}
