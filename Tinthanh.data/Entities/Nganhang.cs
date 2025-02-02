

namespace Tinthanh.Data.Entities
{
 
   
 
    public class Nganhang
    {
        public int Id { get; set; }
        public string Ma { get; set; }
        public string Ten { get; set; }
        public string? Tentat { get; set; }
        public string? Manhom { get; set; }
        public string? Msthue { get; set; }
        public string? Dienthoai { get; set; }
        public string? Email { get; set; }
        public string? Website { get; set; }
        public bool? Ngungsd { get; set; } = false;
        public DateTime? Ngayngungsd { get; set; }
        public DateTime? CreateDate { get; set; } = DateTime.Today;
        public string? Users { get; set; }
        public DateTime? EditDate { get; set; }
        public bool? Congty { get; set; } = false;
        public string? Diachi { get; set; }
 

    }

}
