

using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.ComponentModel.DataAnnotations;

namespace Tinthanh.Data.Entities
{

    public class Khachhang
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
        public DateTime? CreateDate { get; set; } = DateTime.Today;
        public string? Users { get; set; }
        public DateTime? EditDate { get; set; }
      
        public string? Taikhoan { get; set; }
        public string? Diachi { get; set; }
        public int? Thuoc { get; set; }
        public int? Makv { get; set; }
        public double? Soducongno { get; set; }
        public double? Donhang { get; set; }
        public double? Dagiao { get; set; }
        public int? PTVanchuyen { get; set; } = 1;
        public string? Lienhe { get; set; }
        public int? Loaicn { get; set; }
        public int? HanTT { get; set; }
        public int? TileTT { get; set; }
        public int? Ketu { get; set; }
        public int? Songay { get; set; }
        public bool? TheodoiCN { get; set; }
        public double? Maxno { get; set; }
        public string? LinkNhaCC { get; set; }
        public bool? Hoadon { get; set; }
        public bool? Ingia { get; set; }
        public bool? ThanhtoanNH { get; set; }
        public bool? Congty { get; set; }
        public bool? Thuongxuyen { get; set; }
        public bool? VAT { get; set; }
        
        public virtual ObservableCollectionListSource<LienlacKH>? LienlacKHs { get; set; }

 
    }
}
