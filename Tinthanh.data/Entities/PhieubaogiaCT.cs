
using System.ComponentModel.DataAnnotations;


namespace Tinthanh.Data.Entities
{
    public class PhieubaogiaCT
    {
        public int Id { get; set; }
        public int? PhieubaogiaId { get; set; }
      
        public int? Stt { get; set; }
 
        public string? Masp { get; set; }
       
        public string? Tensp { get; set; }
       
        public string? Donvi { get; set; }
        public double? Dongia { get; set; }
        public int? Vat { get; set; }
        public double? Thanhtien { get; set; }
        public double? Trongluong { get; set; }
        public double? Matdo { get; set; }
        public int? Loai { get; set; }
        public int? Socav { get; set; }
        
        public string? Khomay { get; set; }
        public double? DongiaNT { get; set; }
        public double? ThanhtienNT { get; set; }
        public double? GiaSC { get; set; }
        public double? GiaSCNT { get; set; }
        public double? GiaCu { get; set; }
        public double? GiaCuNT { get; set; }
        public double? DongiaKG { get; set; }
        public double? SoluongBG { get; set; }
        public double? Tilevon { get; set; }
        public bool? gc { get; set; }
        public int? Mabo { get; set; }
        public double? SoluongKH { get; set; }
        public double? GiaKH { get; set; }
        public double? GiaKH_USD { get; set; }
        public virtual Phieubaogia Phieubaogia { get; set; }
    }

}
