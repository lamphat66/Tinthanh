

namespace Tinthanh.Data.Entities
{
    public class BanggiaNCC
    {
        public int Id { get; set; }
        public string? MaDT { get; set; }
        public string? MaVT { get; set; }
        public string? Donvi { get; set; }
        public string? TenVT { get; set; }
        public string? TenNB { get; set; }
        public double? Giaban { get; set; }
        public double? Chietkhau { get; set; }
        public double? TienChietKhau { get; set; }
        public double? Giacu { get; set; }
        public DateTime? NgayUpdate { get; set; }=DateTime.Today;
       
        public bool? ROHS { get; set; } = false;
        public int? Baohanh { get; set; }
        public string? Ghichu { get; set; }
        public bool? Hoadon { get; set; } = false;
        public string? Users { get; set; }
        public double? ChietkhauSP { get; set; }
        public double? VAT { get; set; }
         
    }

}
