using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tinthanh.Data.Entities
{
    public class KhachhangTN
    {
        public int Id { get; set; }
        public string Ma { get; set; }
        public string Ten { get; set; }

        public string? Dienthoai { get; set; }
        public string? Email { get; set; }
        public string? Website { get; set; }
        public bool? Ngungsd { get; set; } = false;
        public DateTime? Ngayngungsd { get; set; }
        public DateTime? CreateDate { get; set; } = DateTime.Today;
        public string? Users { get; set; }
        public DateTime? EditDate { get; set; }

        public string? Diachi { get; set; }
        public string? Lienhe { get; set; }

    }
}
