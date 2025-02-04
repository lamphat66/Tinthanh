

namespace Tinthanh.Data.Entities
{
    public class DanhmucCT
    {
        public int Id { get; set; }
        public int DanhmucId { get; set; }
        public int Ma { get; set; }    
        public string? Ten { get; set; }
        public bool Ngungsd { get; set; } = false;
        public virtual Danhmuc? Danhmuc { get; set; }   

    }

}
