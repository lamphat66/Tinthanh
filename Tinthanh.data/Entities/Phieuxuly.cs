using Microsoft.EntityFrameworkCore.ChangeTracking;

using System.ComponentModel.DataAnnotations;

namespace Tinthanh.Data.Entities
{
    public class Phieuxuly
    {
        public int Id { get; set; }
        [MaxLength(20)]
        public string? Maphieu { get; set; }
        public DateTime Ngaylap { get; set; }
        [MaxLength(20)]
        public string? Makh { get; set; }
        [MaxLength(100)]
        public string? Tenkh { get; set; }
        public int? Khomay { get; set; }
        public int? Thoigiangc { get; set; }
       
        public int? Trangthai { get; set; }
        [MaxLength(20)]
        public string? CreateBy { get; set; }
     
      
        [MaxLength(20)]
        public string? EditBy { get; set; }
        public DateTime? EditDate { get; set; }
        [MaxLength(200)]
        public string? Ghichu { get; set; }
        public double? Giakhuon { get; set; }
        [MaxLength(80)]
        public string? Tenkhuon { get; set; }
        public bool? Logo { get; set; }
        [MaxLength(20)]
        public string? Machungtu { get; set; }
        public DateTime? Ngaychungtu { get; set; }
        public int? SoCAV { get; set; }
        public int? Bo { get; set; }
        public int? Kiemtra { get; set; }
        [MaxLength(20)]
        public string? Kekhuon { get; set; }
        public string? Chungtugoc { get; set; }
        public DateTime? Ngaynhan { get; set; }
        [MaxLength(20)]
        public string? Nguoinhan { get; set; }
        public DateTime? Ngayxl { get; set; }
        [MaxLength(20)]
        public string? Nguoixl { get; set; }
        public DateTime? Ngayvc { get; set; }
        [MaxLength(20)]
        public string? Nguoivc { get; set; }
        public  virtual ObservableCollectionListSource<PhieuxulyCT> PhieuxulyCTs { get; set; }
    }

}
