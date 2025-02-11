
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.ComponentModel.DataAnnotations;


namespace Tinthanh.Data.Entities
{
    public class Hopdongkhuon
    {
        public int Id { get; set; }
        [MaxLength(20)]
        public string? Maphieu { get; set; }
        public DateTime Ngaylap { get; set; }
        [MaxLength(20)]
        public string? Sohopdong { get; set; }
        [MaxLength(20)]
        public string? Machungtu { get; set; }
        [MaxLength(20)]
        public string? Makh { get; set; }
        [MaxLength(100)]
        public string? Tenkh { get; set; }
        public int? SoSP { get; set; }
        public int? SonamBH { get; set; }
        public int? ThoigianHT { get; set; }
        public int? TWDot1 { get; set; }
        public int? TWDot2 { get; set; }
        [MaxLength(20)]
        public string? CreateBy { get; set; }
        public int? Hantt { get; set; }
        [MaxLength(200)]
        public string? Ghichu { get; set; }
        [MaxLength(20)]
        public string? EditBy { get; set; }
        public DateTime? EditDate { get; set; }
        public double? GiatriNT { get; set; }
        [MaxLength(100)]
        public string? PathFile { get; set; }
        [MaxLength(20)]
        public string? Bienban { get; set; }
        public int? Trangthai { get; set; }
           
        public virtual ObservableCollectionListSource<HopdongkhuonCT> HopdongkhuonCTs { get; set; } 
    }

}
