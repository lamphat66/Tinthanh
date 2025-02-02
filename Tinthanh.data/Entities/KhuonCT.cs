using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tinthanh.Data.Entities
{
    public class KhuonCT
    {
        public int Id { get; set; }
        public string Masp { get; set; }
        public string? TenSP { get; set; }
        public short? Socav { get; set; }
        public string? Donvi { get; set; }
        public bool? SPchinh { get; set; }
        public double? DaiD { get; set; }
        public double? DaiA { get; set; }
        public double? RongD { get; set; }
        public double? RongA { get; set; }
        public double? CaoD { get; set; }
        public double? CaoA { get; set; }
        public double? Daint { get; set; }
        public double? Rongnt { get; set; }
        public double? Caont { get; set; }
        public double? Daispd { get; set; }
        public double? Daispa { get; set; }
        public double? Rongspd { get; set; }
        public double? Rongspa { get; set; }
        public double? Caospa { get; set; }
        public int? KhuonId { get; set; }
        public int? Nhom { get; set; }
        public double? Caospd { get; set; }
        public virtual Khuon? Khuon { get; set; }
        
    }

}
