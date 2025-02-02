 
namespace Tinthanh.Data.Entities
{
    public class Nhomtaisan
    {
        public string Ma { get; set; }
        public string Ten { get; set; }
        public virtual Loaitaisan Loaitaisan { get; set; }
        public string? Mats { get; set; }
        public bool ? Ngungsd { get; set; }
    }
}
