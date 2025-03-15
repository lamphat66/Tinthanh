using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tinthanh.Data.Entities
{
    public class DieuchinhgiaCT
    {
        public int Id { get; set; }
        public int? DieuchinhgiaId { get; set; }
       
        public string? Makh { get; set; }
        
        public string? Tenkh { get; set; }
     
        public string? Masp { get; set; }
        
        public string? Tensp { get; set; }
        
        public string? Donvi { get; set; }
        public double? Giaban { get; set; }
        public double? Giabannt { get; set; }
        public double? Giamoi { get; set; }
        public double? Giamoint { get; set; }
       
        public string? Khomay { get; set; }
        public double? Matdo { get; set; }
        public int? Socav { get; set; }
        public int? Tinhtrang { get; set; }
        public bool? Chon { get; set; }
        public double? Trongluong { get; set; }
        public virtual Dieuchinhgia Dieuchinhgia { get; set; }
    }

}
