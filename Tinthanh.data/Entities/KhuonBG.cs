

namespace Tinthanh.Data.Entities
{
    public class KhuonBG
    {
        public string Ma { get; set; }
        public string? Ten { get; set; }
       
        public string? CreateBy { get; set; }
        public DateTime? CreateDate { get; set; } = DateTime.Today;
        public string? EditBy { get; set; }
        public DateTime? EditDate { get; set; }
        public bool? Ngungsd { get; set; } = false;

    }
}
