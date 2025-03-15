 
using Tinthanh.Data.EF;
using Tinthanh.Data.Entities;

namespace Tinthanh.App.General
{
    public static class Thuvien
    {
         
        

        public class lkKhomay
        {
            public int Ma { get; set; }
            public string? Ten { get; set; }
        }

        public static List<lkKhomay> GetKhomay()
        {
            TinthanhDBContext db = GetdbContext.dbContext();
            return db.Khomays.Select(x => new lkKhomay { Ma = x.Ma, Ten = x.Ten }).ToList();
        }

        public static List<Donvi> GetDonvi()
        {
            TinthanhDBContext db = GetdbContext.dbContext();
            return db.Donvis.ToList();

        }
    }
}
