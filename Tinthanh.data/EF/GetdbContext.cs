using Tinthanh.Data.Entities;

namespace Tinthanh.Data.EF
{
    public static class GetdbContext
    {
        public static TinthanhDBContext dbContext()
        {
            TinthanhDbContextFactory ft = new TinthanhDbContextFactory();
            return ft.CreateDbContext(Array.Empty<string>());
        }

       

    }
}
