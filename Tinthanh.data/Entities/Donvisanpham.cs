using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tinthanh.Data.Entities
{
    public class Donvisanpham
    {
        public int Id { get; set; }
        public string? Donvi { get; set; }
        public double? Heso { get; set; }
        public double? Trongluong { get; set; }
        public double? Dongia { get; set; }
        public bool? Ngungsd { get; set; }

        public int? ThanhphamId { get; set; }
        public virtual Thanhpham? Thanhpham { get; set; }

        public double? Giakho { get; set; }
        
    }

}
