using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tinthanh.Data.Entities
{
    public class Tailieu
    {
        public int Id { get; set; }
        public string? Tenfile { get; set; }
        public DateTime? Ngay { get; set; }
        public string? Phanloai { get; set; }
        public string? Mota { get; set; }
        public string? Madt { get; set; }
        public bool? Ngungsd { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? Nhomtaileu { get; set; }



    }

}
