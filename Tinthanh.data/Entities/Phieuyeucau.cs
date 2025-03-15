
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Tinthanh.Data.Entities
{
    public class Phieuyeucau
    {
        public int Id { get; set; }
        public string? Maphieu { get; set; }
        public DateTime? Ngaylap { get; set; } = DateTime.Today;
        public DateTime? Ngaychungtu { get; set; } = DateTime.Today;
        public DateTime? Ngayhoanthanh { get; set; }
        public string? Makh { get; set; }
        public string? Tenkh { get; set; }
        public DateTime? Ngaynhan1 { get; set; }
        public string? Nguoinhan1 { get; set; }
        public DateTime? NgayVC1 { get; set; }
        public string? NguoiVC1 { get; set; }
        public DateTime? NgayXL1 { get; set; }
        public string? NguoiXL1 { get; set; }
        public string? Ghichu { get; set; }
        public int? Trangthai { get; set; } = 1;
        public string? Ketluan { get; set; }
        public string? CreateBy { get; set; }
        public string? EditBy { get; set; }
        public DateTime? EditDate { get; set; }
        public string? Diachi { get; set; }
        public string? Dienthoai { get; set; }
        public string? Lienhe { get; set; }
        public virtual ObservableCollectionListSource<PhieuyeucauCT> PhieuyeucauCTs { get; set; }
    }

}
