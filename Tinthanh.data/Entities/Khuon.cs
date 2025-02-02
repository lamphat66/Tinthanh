

using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Tinthanh.Data.Entities
{
    public class Khuon 
    {
       public int Id { get; set; }
        public string Ma { get; set; }
        public string Ten { get; set; }
        public string? Tentat { get; set; }
        public string? Manhom { get; set; }

        public float? SanluongBT { get; set; }
        public short? SongayBT { get; set; }
        public float? Trongluong { get; set; }
        public int? Khomay { get; set; }
        public short? SoCav { get; set; }
        public string? Make { get; set; }
        public short? Chuky { get; set; }
        public short? TGlenkhuon { get; set; }
        public short? TGxuongkhuon { get; set; }
        public string? Ghichu  { get; set; }
        public string? Makh { get; set; }
        public string? TenKH { get; set; }
        public short? Tilevon { get; set; }
        public float? SanluonggiaKH { get; set; }
        public float? ThoigiangiaKH { get; set; }

        public bool? Ngungsd { get; set; } = false;
        public string? Mats { get; set; }
        public string? Users { get; set; }
        public DateTime? CreateDate { get; set; }
        
        public DateTime? EditDate { get; set; }
        public virtual ObservableCollectionListSource<KhuonCT>? KhuonCTs { get; set; }
    

    }


}
