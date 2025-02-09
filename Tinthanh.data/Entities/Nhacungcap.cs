

using Microsoft.EntityFrameworkCore.ChangeTracking;


namespace Tinthanh.Data.Entities
{
    public class Nhacungcap  
    {

        public int Id { get; set; }
        public string Ma { get; set; }
        public string Ten { get; set; }
        public string? Tentat { get; set; }
        public string? Manhom { get; set; }
        public string? Msthue { get; set; }
        public string? Dienthoai { get; set; }
        public string? Email { get; set; }
        public string? Website { get; set; }
        public bool? Ngungsd { get; set; } = false;
        public DateTime? Ngayngungsd { get; set; }
        public string? Ghichu { get; set; }
        public DateTime? Users { get; set; }=DateTime.Today;
        public string? CreateBy { get; set; }
        public DateTime? EditDate { get; set; }
        public double? Soducongno { get; set; }
        public double? Donhang { get; set; }
        public double? Dagiao { get; set; }
        public string? Taikhoan { get; set; }
        public string? Diachi { get; set; }
        public int? PTVanchuyen { get; set; }
         public int? HanTT { get; set; }
        public int? TileTT { get; set; }
        public bool? TheodoiCN { get; set; }
        public double? Maxno { get; set; }
        public bool? ISO { get; set; } = false;
        public string? Linkkh { get; set; }
 
        public bool? Hoadon { get; set; }
        public bool? ThanhtoanNH { get; set; }
        public bool? VAT { get; set; }
 
       
        public virtual ObservableCollectionListSource<LienlacNCC>? LienlacNCCs { get; set; }
        public virtual ObservableCollectionListSource<NhaCC_Tailieu>? NhaCC_Tailieus { get; set; }


    }

}
