

using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.ComponentModel.DataAnnotations;

namespace Tinthanh.Data.Entities
{
    public class ThongtinSP
    {
        public int Id { get; set; }
        [MaxLength(20)]
        public string? Maphieu { get; set; }
        public DateTime? Ngaylap { get; set; }
        public DateTime? Ngaychungtu { get; set; }
        [MaxLength(20)]
        public string? Makh { get; set; }
        [MaxLength(100)]
        public string? Tenkh { get; set; }
        [MaxLength(20)]
        public string? Khomay { get; set; }
        [MaxLength(20)]
        public string? Ngoaiquan { get; set; }
        [MaxLength(80)]
        public string? Yeucaukhac { get; set; }
        [MaxLength(20)]
        public string? Makhuon { get; set; }
        [MaxLength(100)]
        public string? Tenkhuon { get; set; }
        [MaxLength(20)]
        public string? Kekhuon { get; set; }
        public double? Dautukh { get; set; }
        public double? Dautucty { get; set; }
        public bool? Maus { get; set; }
        public int? Loaikt { get; set; }
        public bool? Logo { get; set; }
       
   
        public string? CreateBy { get; set; }
        public string? EditBy { get; set; }
        public DateTime? EditDate { get; set; }
     
        public int? Trangthai { get; set; }
        public int? Socav { get; set; }
        public int? Bo { get; set; }
        public int? SLChaymau { get; set; }
        [MaxLength(20)]
        public string? CopyFrom { get; set; }
        [MaxLength(20)]
        public string? CopyTo { get; set; }
        [MaxLength(20)]

        public virtual ObservableCollectionListSource<ThongtinSP_CT>ThongtinSP_CTs { get; set; }
    }

}
