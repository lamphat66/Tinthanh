

using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Tinthanh.Data.Entities
{
    public class Xemay
    {
        public int Id { get; set; }
        public string Ma { get; set; }
        public string Ten { get; set; }
        public string? Tentat { get; set; }
        public string? Manhom { get; set; }
        public string? NhaSX { get; set; }
        public int NamSX { get; set; }
        public string? NuocSX { get; set; }
        public bool? Baotri { get; set; }
        public DateTime? NgaySD { get; set; }
        public short? Trongluong { get; set; }
        public string? Bienso { get; set; }
        public bool? Kiemdinh { get; set; }
        public bool? Baohiem { get; set; } = false;
        public bool? Mabuchi { get; set; } = false;
        public string? Model { get; set; }
        public short? Socho { get; set; }
        public double? Taitrong { get; set; }
        public int Namdangky { get; set; }
        public int Namhethan { get; set; }
        public string? Somay { get; set; }
        public string? Loaithung { get; set; }
        public double? Thetichthung { get; set; }
        public string? Kichthuocthung { get; set; }
        public string? Sokhung { get; set; }
        public DateTime? Hancavet { get; set; }
        public double? Dinhmucdau { get; set; }
        public bool? Xegiaohang { get; set; }
        public DateTime? HanbaotriDB { get; set; }
        public DateTime? Hanbaohanh { get; set; }
        public string? Ghichu { get; set; }
        public DateTime? NgayngungSD { get; set; }
        public string? EditBy { get; set; }
        public DateTime? EditDate { get; set; }
        public string? CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public bool? Ngungsd { get; set; } = false;
        public bool? Xuatdau { get; set; } = false;
        public string? Mats { get; set; }
      
        public virtual ObservableCollectionListSource<XeBaoTri>? XeBaoTris { get; set; }
        public virtual ObservableCollectionListSource<XeHoatdong>? XeHoatdongs  { get; set; }
    }


}
