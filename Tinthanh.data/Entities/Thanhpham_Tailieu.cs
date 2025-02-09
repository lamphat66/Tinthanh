 
 

namespace Tinthanh.Data.Entities
{
    public class Thanhpham_Tailieu
    {
        

        public int Id { get; set; }

        public string? Tenfile { get; set; }
        public int ThanhphamId { get; set; }

        public DateTime? Ngaylap { get; set; }

        public string? Phanloai { get; set; }

        public string? Mota { get; set; }

        public bool? Ngungsd { get; set; }
        public Thanhpham? Thanhpham { get; set; }
    }
}
