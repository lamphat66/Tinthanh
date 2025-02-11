

using System.ComponentModel.DataAnnotations;

namespace Tinthanh.Data.Entities
{
    public class PhieuyeucauCT
    {
        public int Id { get; set; }
        [MaxLength(20)]
        public string? Masp { get; set; }
        [MaxLength(100)]
        public string? Tensp { get; set; }
        [MaxLength(20)]
        public string? Donvi { get; set; }
        public int? Soluong { get; set; }
        public int? Khomay { get; set; }
        [MaxLength(200)]
        public string? Ghichu { get; set; }
        public int? Ketqua { get; set; }
        public int? Loaisp { get; set; }
        public int? Xuly { get; set; }
        public int? Yeucau { get; set; }
        public int? KhomayKH { get; set; }
        public int? Socav { get; set; }
        public int? SocavT { get; set; }
        public int? Thoihan { get; set; }

        public string? Tinhtrang { get; set; }
        public string? YeucauT { get; set; }
        public double? GiaSC { get; set; }
        public double? SoluongDH { get; set; }
        public int? Lanthang { get; set; }
        public int? SoluongMin { get; set; }
        public int? Nhomkhuon { get; set; }
        public int? PhieuyeucauId { get; set; }
        public virtual Phieuyeucau Phieuyeucau { get; set; }
    }

}
