
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Tinthanh.App.Tiepnhan;

namespace Tinthanh.Data.EF
{
    public class TinthanhDbContextFactory : IDesignTimeDbContextFactory<TinthanhDBContext>
    {
        public TinthanhDBContext CreateDbContext(string[] args)
        {
            var Service = new ServiceCollection();
            
            Service.AddScoped(typeof(IRepository<>),typeof(Repository<>));

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
