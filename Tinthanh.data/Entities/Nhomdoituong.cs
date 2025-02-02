 

namespace Tinthanh.Data.Entities
{
    public class Nhomdoituong
    {
        public string Ma { get; set; }
        public string? Ten { get; set; }
        public virtual Loaidoituong? Loaidoituong { get; set; }  
        public string? Madt { get; set; }
        public bool? Ngungsd { get; set; }
    }
}
