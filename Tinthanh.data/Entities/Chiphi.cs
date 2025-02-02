

using System.ComponentModel.DataAnnotations;

namespace Tinthanh.Data.Entities
{
    public class Chiphi 
    {
        public int Id { get; set; }
       
        public string? Ma { get; set; }
        public string? Ten { get; set; }
        public string? Loai { get; set; }
        public string? Taikhoan { get; set; }
        public bool? Ngungsd { get; set; } = false;
    }
}
