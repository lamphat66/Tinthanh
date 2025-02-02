using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tinthanh.Data.Entities
{
    public class MaymocTB
    {
        public int Id { get; set; }
        public string Ma { get; set; }
        public string Ten { get; set; }
        public string? Tentat { get; set; }
        public string? Manhom { get; set; }
        public string? NhaSX { get; set; }
        public int NamSX { get; set; }
        public string? Sohieu { get; set; }
        public string? NuocSX { get; set; }
        public bool? Baotri { get; set; } = false;
        public DateTime? NgaySD { get; set; }
        public string? Ghichu { get; set; }
        public DateTime? NgayngungSD { get; set; }
        
        public DateTime? EditDate { get; set; }
        public string? Users { get; set; }
        public DateTime? CreateDate { get; set; }=DateTime.Today;
        public bool? Kiemdinh { get; set; } = false;
        public DateTime? Hanbaohanh { get; set; }
        public DateTime? HanbaotriDB { get; set; }
        public bool? Ngungsd { get; set; } = false;
        public string? Model { get; set; }
        public string? Thongso { get; set; }
        public string? sochetao { get; set; }
        public short? Trongluong { get; set; }
        public float? Taitrong { get; set; }
        public string? Congdung { get; set; }
        public string? Soxacnhan { get; set; }
        public string? Bienlai { get; set; }
        public bool? Nghiemnhat { get; set; }
        public string? Vitri { get; set; }
        public bool? Xuatdau { get; set; }=false;
        public string? Mats { get; set; }
        public bool? Baotringoai { get; set; } = false;
    }

}
