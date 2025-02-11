using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tinthanh.Data.Entities
{
    public class PhieuxulyCT
    {
        public int Id { get; set; }
        public int PhieuxulyId { get; set; }
        public string? Masp { get; set; }
        public string? Tensp { get; set; }
        public double? Thetich { get; set; }
        public double? Titrong { get; set; }
        public double? Trongluong { get; set; }
        public double? Dai { get; set; }
        public double? Rong { get; set; }
        public double? Cao { get; set; }
        public int? Socav { get; set; }
        public string Donvi { get; set; }
        public int? Yeucau { get; set; }
        public double? DaiD { get; set; }
        public double? DaiA { get; set; }
        public double? RongD { get; set; }
        public double? RongA { get; set; }
        public double? CaoD { get; set; }
        public double? CaoA { get; set; }
        public double? daikd { get; set; }
        public double? daika { get; set; }
        public double? rongkd { get; set; }
        public double? rongka { get; set; }
        public double? caokd { get; set; }
        public double? caoka { get; set; }
        public virtual Phieuxuly Phieuxuly { get; set; }
    }

}
