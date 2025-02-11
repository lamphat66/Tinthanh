
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.ComponentModel.DataAnnotations;


namespace Tinthanh.Data.Entities
{
    public class Phieubaogia
    {
        public int Id { get; set; }
        [MaxLength(20)]
        public string? Maphieu { get; set; }
        public DateTime Ngaylap { get; set; }
        [MaxLength(20)]
        public string? Makh { get; set; }
        [MaxLength(100)]
        public string? Tenkh { get; set; }
        [MaxLength(200)]
        public string? Ghichu { get; set; }
        [MaxLength(100)]
        public string? Diachi { get; set; } 
        [MaxLength(100)]
        public string? Nguoilienhe { get; set; }
        [MaxLength(20)]
        public string? Dienthoai { get; set; }
        public int? Hieuluc { get; set; }
        public bool? HinhthucTT { get; set; }
        public int? HanTT { get; set; }
        public int? PTVanchuyen { get; set; }
        public int? TW1 { get; set; }
        public int? TW2 { get; set; }
        public int? Songaykhuon { get; set; }
        public int? Trangthai { get; set; }
        public int? Solan { get; set; }
        public DateTime? Ngaychungtu { get; set; }
        public DateTime? Ngayduyet { get; set; }
        public bool? Ngoaite { get; set; }
        public int? DKTT { get; set; }
        public int? ThoihanTT { get; set; }
        public double? Maxno { get; set; }
        public double? TileTT { get; set; }
        public int? SongayLH { get; set; }
        [MaxLength(200)]
        public string? GhichuNB { get; set; }
        public int? Tigia { get; set; }
      
        [MaxLength(20)]
        public string? CreateBy { get; set; }
     
        [MaxLength(20)]
        public string? EditBy { get; set; }
        public DateTime? EditDate { get; set; }
        [MaxLength(20)]
        public string? Machungtu { get; set; }
        [MaxLength(20)]
        public string? Chungtugoc { get; set; }
        public virtual ObservableCollectionListSource<PhieubaogiaCT>PhieubaogiaCTs { get; set; }
    }

}
