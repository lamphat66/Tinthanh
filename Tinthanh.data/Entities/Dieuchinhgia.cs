
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.ComponentModel.DataAnnotations;

namespace Tinthanh.Data.Entities
{
    public class Dieuchinhgia
    {
        public int Id { get; set; }

        public string? Maphieu { get; set; }
        public DateTime? Ngaylap { get; set; }
        public string? Nhomsp { get; set; }
        public string? Makv { get; set; }
        public string? Makh { get; set; }
        public string? Tenkh { get; set; }
        public int? Tanggiam { get; set; }
        public int? Tuychon { get; set; }
        public double? Giatri { get; set; }
        public int? Trangthai { get; set; }
        public string? CreateBy { get; set; }
        public string? EditBy { get; set; }
        public DateTime? EditDate { get; set; }
        public DateTime? Ngaychungtu { get; set; }
        public ObservableCollectionListSource<DieuchinhgiaCT> DieuchinhgiaCTs { get; set; }
    }

}
