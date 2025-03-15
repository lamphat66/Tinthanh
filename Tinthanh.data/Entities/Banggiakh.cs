
namespace Tinthanh.Data.Entities
{
    public class BanggiaKH
    {
        public int Id { get; set; }
        
        public int KhachhangId { get; set; }
        public int SanphamId { get; set; }
        public string? Masp { get; set; }
        public string? Makh { get; set; }
        public string? Marieng { get; set; }
        public string? Donvi { get; set; }
        public string? TenSPKH { get; set; }
        public string? TenSPTT { get; set; }
        public double? Giaban { get; set; }
        public double? Giabannt { get; set; }
        public double? Giacu { get; set; }
        public double? GiacuNT { get; set; }
        public double? Trongluong { get; set; }
        public double? Matdo { get; set; }
        public string? Khomay { get; set; }
        public int? SoCAV { get; set; }
        public string? Users { get; set; }
        public DateTime? Ngaygiagoc { get; set; }=DateTime.Today;
        public DateTime? Ngaycapnhat { get; set; }
        public double? Giaao { get; set; }
        public double? Giale { get; set; }
        public short? Trangthai { get; set; }
    }

}
