

namespace Tinthanh.Data.Entities
{
    public class Banggiale
    {
        public int Id { get; set; }
        public string? Masp { get; set; }
        public string? TenSP { get; set; }
        public string? Donvi { get; set; }
        public float? Giaban { get; set; }
        public string? Khomay { get; set; }
        public float? Matdo { get; set; }
        public float? Users { get; set; }
        public DateTime? NgayUpdate { get; set; } = DateTime.Today;
    }

}
