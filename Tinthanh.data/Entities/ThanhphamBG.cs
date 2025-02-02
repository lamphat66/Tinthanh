

namespace Tinthanh.Data.Entities
{
    public class ThanhphamBG 
    {
        public int Id { get; set; }
        public string Ma { get; set; }
        public string? Ten { get; set; }
       
        public string ? Donvi { get; set; }
        public string? Users { get; set; }
        public DateTime? CreateDate { get; set; } = DateTime.Today;
        
        public DateTime? EditDate { get; set; }
        public bool? Ngungsd { get; set; } = false; 

    }
}
