 
using System.ComponentModel.DataAnnotations;


namespace Tinthanh.Data.Entities
{
    public class Phieuthukhuon
    {
        public int Id { get; set; }
        [MaxLength(20)]
        public string? Maphieu { get; set; }
        public DateTime Ngaylap { get; set; }
        public DateTime? Ngaychungtu { get; set; }
             
        public int? Tinhdien { get; set; }
        public DateTime? Ngaygiao { get; set; }
        [MaxLength(20)]
        public string? Machungtu { get; set; }
        public int? Slmau { get; set; }
        public DateTime? TGChayDK { get; set; }
        public string? MayKichHat { get; set; }
        public string? MayDinhHinh { get; set; }
        public DateTime? Ngaykichhat { get; set; }
        public DateTime? NgayChaymau { get; set; }
        public DateTime? Tu { get; set; }
        public DateTime? Den { get; set; }
        [MaxLength(20)]
        public string? NVkichhat { get; set; }
        [MaxLength(20)]
        public string? NVvanhanh { get; set; }
        public int? ChuKy { get; set; }
        public float? SLKich { get; set; }
        [MaxLength(20)]
        public string? Loaihat { get; set; }
        public float? TLBadauMax { get; set; }
        public float? TLBadauMin { get; set; }
        public float? TLThanhphamMax { get; set; }
        public float? TLThanhphammin { get; set; }
        public float? Titrong { get; set; }
        public int? SoCK { get; set; }
        public int? SoSP { get; set; }
        public int? TGU { get; set; }
        public int? SPOK { get; set; }
        public int? SPNG { get; set; }
        [MaxLength(200)]
        public string? GhichuKM { get; set; }
        [MaxLength(20)]
        public string? PhieuKT { get; set; }
        [MaxLength(20)]
        public string? Loaibao { get; set; }
        public int? SLBao { get; set; }
        public int? QCngang { get; set; }
        [MaxLength(200)]
        public string? GhichuDG { get; set; }
        public int? QCD { get; set; }
        public int? QCL { get; set; }
        [MaxLength(80)]
        public string? Tenbao { get; set; }
        [MaxLength(80)]
        public string? TenNhua { get; set; }
        [MaxLength(100)]
        public string? Tenkichhat { get; set; }
        [MaxLength(1000)]
        public string? TenDinhhinh { get; set; }
        [MaxLength(200)]
        public string? GhichuCM { get; set; }
        [MaxLength(20)]
        public string? Chungtugoc { get; set; }
        [MaxLength(20)]
        public string? Makhuon { get; set; }
        [MaxLength(100)]
        public string? Tenkhuon { get; set; }
        public int? Trangthai { get; set; }
        public DateTime? DateEdit { get; set; }
        [MaxLength(20)]
        public string? EditBy { get; set; }
        [MaxLength(20)]
        public string? CreateBy { get; set; }   


    }

}
