using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tinthanh.Data.Entities
{
    public class XeBaoTri
    {
        public int Id { get; set; }
        public int? XemayId { get; set; }
        public int? Sokm { get; set; }
        public double? Sogio { get; set; }
        public int? Congviec { get; set; }
        public string? Ghichu { get; set; }
        public string? Hinhthuc { get; set; }
        public double? Sokmdau { get; set; }
        public int? Sogiodau { get; set; }
        public string? Soxe { get; set; }
        public virtual Xemay? Xemay { get; set; }
        
    }

}
