
using Tinthanh.Data.EF;

namespace Tinthanh.App.General
{
    public static class GetdbContext
    {
        public static TinthanhDBContext dbContext ()
        {
            TinthanhDbContextFactory ft = new TinthanhDbContextFactory();
            return  ft.CreateDbContext(Array.Empty<string>());
        }
    }
}
