

using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Tinthanh.Data.Entities
{

   
    public class Thanhpham
    {
        public int Id { get; set; }
        public string Ma { get; set; }
        public string? Ten { get; set; }
        public string? Tentat { get; set; }
        public string? Manhom { get; set; }
        public bool? Ngungsd { get; set; } = false;
        public DateTime? Ngayngungsd { get; set; }
        public string? Ghichu { get; set; }
        public string? Users { get; set; }
        public DateTime? CreateDate { get; set; } = DateTime.Today;
        
        public DateTime? EditDate { get; set; }
        public string? TKkho { get; set; }
        public string? TKphi { get; set; }

 
        public string? Donvi { get; set; }
        public bool? Ban { get; set; } = true;
        public bool? Mua { get; set; } = false;
        public bool? Ton { get; set; } = true;
        public double? Dai { get; set; }
        public double? Rong { get; set; }
        public double? Cao { get; set; }
        public double? Trongluong { get; set; }
        public double? Thetich { get; set; }
        public double? Tonmax { get; set; }
        public double? Tonmin { get; set; }
        public bool? Cohinh { get; set; } = false;
        public string? Quycach { get; set; }
        public double? Tonreq { get; set; }
        public int? Tinhgia { get; set; }
        public string? Kho { get; set; }
        public string? Mabo { get; set; }
        public double? Hesobo { get; set; }
        public double? Titrong { get; set; }
 
 
        public virtual ObservableCollectionListSource<Donvisanpham>? Donvisanphams { get; set; }
 
    }

}
