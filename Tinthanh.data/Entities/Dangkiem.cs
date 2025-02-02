 

namespace Tinthanh.Data.Entities
{
    public class Dangkiem
    {
        public int Id { get; set; }
        public string? Madt { get; set; }
        public string? Soct { get; set; }
        public DateTime? Ngayct { get; set; }=DateTime.Today;
        public double? Giatri { get; set; }
        public string? Nhacc { get; set; }
        public string? Loai { get; set; }
        public DateTime? Ngaydenhan { get; set; }
        public string? Tennhacc { get; set; }
        public bool? Ngungsd { get; set; } = false;
        public string? Tailieu { get; set; }
        public string? Sohieu { get; set; }
    }

}
