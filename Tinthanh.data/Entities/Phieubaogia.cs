
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.ComponentModel.DataAnnotations;


namespace Tinthanh.Data.Entities
{
    public class Phieubaogia
    {
        public int Id { get; set; }

        public string? Maphieu { get; set; }
        public DateTime Ngaylap { get; set; }
        public string? Makh { get; set; }
        public string? Tenkh { get; set; }
        public string? Ghichu { get; set; }
        public string? Diachi { get; set; }
        public string? Nguoilienhe { get; set; }
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
        public string? GhichuNB { get; set; }
        public int? Tigia { get; set; }
        public string? CreateBy { get; set; }
        public string? EditBy { get; set; }
        public DateTime? EditDate { get; set; }
        public virtual ObservableCollectionListSource<PhieubaogiaCT> PhieubaogiaCTs { get; set; }
    }

}
