
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.ComponentModel.DataAnnotations;


namespace Tinthanh.Data.Entities
{
    public class Hopdongkhuon
    {
        public int Id { get; set; }
        
        public string? Maphieu { get; set; }
        public DateTime Ngaylap { get; set; }
        public DateTime Ngaychungtu { get; set; }
        
        public string? Sohopdong { get; set; }
      
        public string? Makh { get; set; }
         
        public string? Tenkh { get; set; }
        public int? SoSP { get; set; }
        public int? SonamBH { get; set; }
        public int? ThoigianHT { get; set; }
        public int? TWDot1 { get; set; }
        public int? TWDot2 { get; set; }
      
        public string? CreateBy { get; set; }
        public int? Hantt { get; set; }
      
        public string? Ghichu { get; set; }
       
        public string? EditBy { get; set; }
        public DateTime? EditDate { get; set; }
        public double? GiatriNT { get; set; }
        
        public string? PathFile { get; set; }
        
        public string? Bienban { get; set; }
        public int? Trangthai { get; set; }
           
        public virtual ObservableCollectionListSource<HopdongkhuonCT> HopdongkhuonCTs { get; set; } 
    }

}
