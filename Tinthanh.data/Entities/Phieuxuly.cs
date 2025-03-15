using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Tinthanh.Data.Entities
{
    public class Phieuxuly
    {
        public int Id { get; set; }
        public string? Maphieu { get; set; }
        public DateTime Ngaylap { get; set; } = DateTime.Today;
        public DateTime Ngaychungtu { get; set; } = DateTime.Today;
        public string? Makh { get; set; }
        public string? Tenkh { get; set; }
        public int? Khomay { get; set; }
        public int? Thoigiangc { get; set; }
        public int? Trangthai { get; set; } = 1;
        public string? CreateBy { get; set; }
        public string? EditBy { get; set; }
        public DateTime? EditDate { get; set; }
        public string? Ghichu { get; set; }
        public double? Giakhuon { get; set; }
        public string? Tenkhuon { get; set; }
        public bool? Logo { get; set; }
        public int? SoCAV { get; set; }
        public int? Bo { get; set; }
        public int? Kiemtra { get; set; }
        public string? Kekhuon { get; set; }
        public DateTime? Ngaynhan { get; set; }
        public string? Nguoinhan { get; set; }
        public DateTime? Ngayxl { get; set; }
        public string? Nguoixl { get; set; }
        public DateTime? Ngayvc { get; set; }
        public string? Nguoivc { get; set; }
        public virtual ObservableCollectionListSource<PhieuxulyCT> PhieuxulyCTs { get; set; }
    }

}
