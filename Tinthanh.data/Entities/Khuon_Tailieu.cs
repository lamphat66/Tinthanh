 
 

namespace Tinthanh.Data.Entities
{
    public class Khuon_Tailieu
    {
        

        public int Id { get; set; }

        public string? Tenfile { get; set; }
        public int KhuonId { get; set; }

        public DateTime? Ngaylap { get; set; }

        public string? Phanloai { get; set; }

        public string? Mota { get; set; }

        public bool? Ngungsd { get; set; }
        public Khuon? Khuon { get; set; }
    }
}
