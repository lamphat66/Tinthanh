
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.ComponentModel.DataAnnotations;

namespace Tinthanh.Data.Entities
{
    public class Dieuchinhgia
    {
        public int Id { get; set; }
        [MaxLength(20)]
        public string? Maphieu { get; set; }
        public DateTime? Ngaylap { get; set; }
        [MaxLength(20)]
        public string? Nhomsp { get; set; }
        [MaxLength(20)]
        public string? Makv { get; set; }
        [MaxLength(20)]
        public string? Tenkv { get; set; }
        [MaxLength(20)]
        public string? Makh { get; set; }
        [MaxLength(20)]
        public string? Tenkh { get; set; }
        public int? Tanggiam { get; set; }
        public int? Tuychon { get; set; }
        public double? Giatri { get; set; }
        public int? Trangthai { get; set; }
        [MaxLength(20)]
        public string? CreateBy { get; set; }
        [MaxLength(20)]
        public string? EditBy { get; set; }
        public DateTime? EditDate { get; set; }
       
        public DateTime? Ngaychungtu { get; set; }
        public ObservableCollectionListSource<DieuchinhgiaCT>DieuchinhgiaCTs { get; set; }  
    }

}
