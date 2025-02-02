

namespace Tinthanh.Data.Entities
{
    public class TieuchiCT
    {
        public int Id { get; set; }
       
        public int MaKT { get; set; }
        public string? Ten { get; set; }
        public virtual TieuchiKT? TieuchiKT { get; set; }
        public int TieuchiKTMa { get; set; }

    }

}
