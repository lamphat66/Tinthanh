
using System.ComponentModel.DataAnnotations;


namespace Tinthanh.Data.Entities
{
    public class HopdongkhuonCT
    {
        public int Id { get; set; }
        public int? HopdongkhuonId { get; set; }
       
        public string? Maphieu { get; set; }
        
        public string? Makhuon { get; set; }
         
        public string? Tenkhuon { get; set; }
        public int? Socav { get; set; }
       
        public string? Khomay { get; set; }
      
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
