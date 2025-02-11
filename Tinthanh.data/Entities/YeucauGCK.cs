
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.ComponentModel.DataAnnotations;

namespace Tinthanh.Data.Entities
{
    public class YeucauGCK
    {
        public int Id { get; set; }
        [MaxLength(20)]
        public string? Maphieu { get; set; }
        public DateTime? Ngaylap { get; set; }
        [MaxLength(20)]
        public string? MaKH { get; set; }
        [MaxLength(100)]
        public string? TenKH { get; set; }
        [MaxLength(20)]
        public string? Makhuon { get; set; }
        [MaxLength(100)]
        public string? Tenkhuon { get; set; }
        public DateTime? BatdauTK { get; set; }
        public DateTime? HoanthanhTK { get; set; }
        public DateTime? GiaomauTK { get; set; }
        public DateTime? BatdauGC { get; set; }
        public DateTime? HoanthanhGC { get; set; }
        public DateTime? GiaomauGC { get; set; }
        [MaxLength(20)]
        public string? Khomay { get; set; }
        public int? SoCAV { get; set; }
        [MaxLength(100)]
        public string? Yeucau { get; set; }
        [MaxLength(20)]
        public string? Machungtu { get; set; }
        public bool? KhuonNB { get; set; }
        [MaxLength(100)]
        public string? PathFile { get; set; }
        [MaxLength(20)]
        public string? CreateBy { get; set; }
        public DateTime? DateEdit { get; set; }
        public string? EditBy { get; set; }
        public int? Hinhthuc { get; set; }
        [MaxLength(100)]
        public string? Dinhkem { get; set; }
        
        [MaxLength(20)]
        public string? Bienban { get; set; }
        public int? Tinhtrang { get; set; }
        public int? Trangthai { get; set; }
        public DateTime? Ngaychungtu { get; set; }
 
        public DateTime? Ngaynhankhuon { get; set; }
        public DateTime? Ngaythumau { get; set; }
        public DateTime? Ngaygiaokhuon { get; set; }
        public DateTime? Ngayhoanthanh { get; set; }
        [MaxLength(20)]
        public string? Chungtugoc { get; set; }

        public virtual ObservableCollectionListSource<YeucauGCK_CT> YeucauGCK_CTs {  get; set; } 
    }

}
