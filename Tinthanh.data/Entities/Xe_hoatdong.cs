using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tinthanh.Data.Entities
{
    public class XeHoatdong
    {
        public int Id { get; set; }
        public int XemayId { get; set; }
        public double? Sokm { get; set; }
        public double? Sogio { get; set; }
        public string? Ghichu { get; set; }
        public DateTime? Ngay { get; set; }
        public string? Soxe { get; set; }
        public virtual Xemay? Xemay { get; set; }
        

    }

}
