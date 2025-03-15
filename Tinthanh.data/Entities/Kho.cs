
using System.ComponentModel.DataAnnotations;

namespace Tinthanh.Data.Entities
{
    public class Kho  
    {
 
        public int Id { get; set; }
        public string Ma { get; set; }
        public string Ten { get; set; }
        public string? Tentat { get; set; }
        public string? Manhom { get; set; }
        public string? Dienthoai { get; set; }
        public string? Email { get; set; }
        public bool? Ngungsd { get; set; } = false;
        public DateTime? Ngayngungsd { get; set; }
        public DateTime? CreateDate { get; set; } = DateTime.Today;
        public string? Users { get; set; }
        public DateTime? EditDate { get; set; }= DateTime.Today;
        public string? Taikhoan { get; set; }
        public string? Diachi { get; set; }
        public bool? Kho_ao { get; set; } = false;
        public bool? vitri { get; set; } = false;
       
        //[MaxLength(20)]
        //public string? Macu { get; set; }

    }


}
