
using System.ComponentModel.DataAnnotations;


namespace Tinthanh.Data.Entities
{
    public class HopdongkhuonCT
    {
        public int Id { get; set; }
        public int? HopdongkhuonId { get; set; }
        [MaxLength(20)]
        public string? Maphieu { get; set; }
        [MaxLength(20)]
        public string? Makhuon { get; set; }
        [MaxLength(100)]
        public string? Tenkhuon { get; set; }
        public int? Socav { get; set; }
        [MaxLength(20)]
        public string? Khomay { get; set; }
        [MaxLength(20)]
        public string? Donvi { get; set; }
        public double? Dongia { get; set; }
        public double? Thanhtien { get; set; }
        public double? Dongiant { get; set; }
        public double? Thanhtiennt { get; set; }
        public int? Vat { get; set; }
        public int? Soluong { get; set; }
        public virtual Hopdongkhuon Hopdongkhuon { get; set; }
    }

}
