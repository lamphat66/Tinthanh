

using System.ComponentModel.DataAnnotations;

namespace Tinthanh.Data.Entities
{
    public class PhieuyeucauCT
    {
        public int Id { get; set; }
       
        public string? Masp { get; set; }
       
        public string? Tensp { get; set; }
       
        public string? Donvi { get; set; }
        public int? Soluong { get; set; } = 1;
        public int? Khomay { get; set; }
      
        public string? Ghichu { get; set; }
        public int? Ketqua { get; set; }
        public int? Loaisp { get; set; } = 2;
        public int? Xuly { get; set; } = 1;
        public int? Yeucau { get; set; } = 1;
        public int? KhomayKH { get; set; }
        public int? Socav { get; set; }
        public int? SocavT { get; set; }
        public int? Thoihan { get; set; }
        public string? Tinhtrang { get; set; }
        public string? YeucauT { get; set; }
        public double? GiaSC { get; set; }
        public double? SoluongDH { get; set; }
        public int? Lanthang { get; set; } = 1;
        public int? SoluongMin { get; set; }
        public int? Nhomkhuon { get; set; }
        public int? PhieuyeucauId { get; set; }
        public virtual Phieuyeucau Phieuyeucau { get; set; }
    }

}
