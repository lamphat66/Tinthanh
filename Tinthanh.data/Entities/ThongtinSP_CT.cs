using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tinthanh.Data.Entities
{
    public class ThongtinSP_CT
    {
        public int ID { get; set; }
        [MaxLength(20)]
        public string? MaSP { get; set; }
        [MaxLength(100)]
        public string? TenSP { get; set; }
        public double? Dai { get; set; }
        public double? Rong { get; set; }
        public double? Cao { get; set; }
        [MaxLength(20)]
        public string? LoaiSL { get; set; }
        public double? Trongluong { get; set; }
        public double? Titrong { get; set; }
        public double? Thetich { get; set; }
        public double? Sanluong { get; set; }
        public double? DaiD { get; set; }
        public double? DaiA { get; set; }
        public double? RongD { get; set; }
        public double? RongA { get; set; }
        public bool? SPChinh { get; set; }
        public double? CaoD { get; set; }
        public double? CaoA { get; set; }
        public double? Socav { get; set; }
        public double? daikd { get; set; }
        public double? daika { get; set; }
        public double? rongkd { get; set; }
        public double? rongka { get; set; }
        public double? caokd { get; set; }
        public double? caoka { get; set; }
        public int? ThongtinSPId { get; set; }
        [MaxLength(20)]
        public string? Donvi { get; set; }
        public virtual ThongtinSP ThongtinSP { get; set; }
    }

}
