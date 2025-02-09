 
 

namespace Tinthanh.Data.Entities
{
    public class NhaCC_Tailieu
    {
        

        public int Id { get; set; }

        public string? Tenfile { get; set; }
        public int NhacungcapId { get; set; }

        public DateTime? Ngaylap { get; set; }

        public string? Phanloai { get; set; }

        public string? Mota { get; set; }

        public bool? Ngungsd { get; set; }
        public Nhacungcap? Nhacungcap { get; set; }
    }
}
