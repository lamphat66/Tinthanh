using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.ComponentModel.DataAnnotations;


namespace Tinthanh.Data.Entities
{
    public class Phieuyeucau
    {
        public int Id { get; set; }
        [MaxLength(20)]
        public string Maphieu { get; set; }
        public DateTime? Ngaylap { get; set; }
        public DateTime? Ngaychungtu { get; set; }
        [MaxLength(20)]
        public string? Makh { get; set; }
        [MaxLength(100)]
        public string? Tenkh { get; set; }
        public DateTime? Ngaynhan1 { get; set; }
        [MaxLength(20)]
        public string? Nguoinhan1 { get; set; }
        public DateTime? NgayVC1 { get; set; }
        [MaxLength(20)]
        public string? NguoiVC1 { get; set; }
        public DateTime? NgayXL1 { get; set; }
        [MaxLength(20)]
        public string? NguoiXL1 { get; set; }
        [MaxLength(200)]
        public string? Ghichu { get; set; }
       
        public int? Trangthai { get; set; }
        public string? Ketluan { get; set; }
        [MaxLength(20)]
        public string? CreateBy { get; set; }
    
        [MaxLength(20)]
        public string? EditBy { get; set; }
        public DateTime? EditDate { get; set; }
        [MaxLength(100)]
        public string? Diachi { get; set; }
        [MaxLength(20)]
        public string? Dienthoai { get; set; }
        [MaxLength(20)]
        public string? Lienhe { get; set; }
        [MaxLength(20)]
        public string? Chungtugoc { get; set; }
        public virtual ObservableCollectionListSource<PhieuyeucauCT> PhieuyeucauCTs { get; set; }
    }

}
