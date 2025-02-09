 
 

namespace Tinthanh.Data.Entities
{
    public class Khachhang_Tailieu
    {
        

        public int Id { get; set; }

        public string? Tenfile { get; set; }
        public int KhachhangId { get; set; }

        public DateTime? Ngaylap { get; set; }

        public string? Phanloai { get; set; }

        public string? Mota { get; set; }

        public bool? Ngungsd { get; set; }
        public Khachhang? Khachhang { get; set; }
    }
}
