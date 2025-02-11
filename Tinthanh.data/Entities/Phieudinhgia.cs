using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tinthanh.Data.Entities
{
    public class Phieudinhgia
    {
        public int Id { get; set; }
        [MaxLength(20)]
        public string? Maphieu { get; set; }
        public DateTime? Ngaylap { get; set; }
        [MaxLength(20)]
        public string? MaSP { get; set; }
        [MaxLength(100)]
        public string? TenSP { get; set; }
        [MaxLength(20)]
        public string? MAKH { get; set; }
        [MaxLength(100)]
        public string? TenKH { get; set; }
        public double? Thetich { get; set; }
        public double? Titrong { get; set; }
        public double? Gia1 { get; set; }
        public double? Gia2 { get; set; }
        public double? Gia3 { get; set; }
        public double? Gia4 { get; set; }
        public double? Gia5 { get; set; }
        public double? Khoiluong { get; set; }
        public double? Sanluong { get; set; }
        public int? SoCAV { get; set; }
        [MaxLength(20)]
        public string? Khomay { get; set; }
        public double? LoinhuanCK { get; set; }
        public double? Dai { get; set; }
        public double? Rong { get; set; }
        public double? Cao { get; set; }
        public bool? Logo { get; set; }
        public int? Buocgia { get; set; }
        public int? SaisoTT { get; set; }
        public int? SaisoKL { get; set; }
        public double? Giachon { get; set; }
        [MaxLength(20)]
        public string? SLTheo { get; set; }
        public double? GiaSP { get; set; }
        public double? Giakhuon { get; set; }
        [MaxLength(200)]
        public string? Ghichu { get; set; }
        public int? Hanthanhtoan { get; set; }
        public int? TGlamkhuon { get; set; }
        public double? GiakhuonBG { get; set; }
        public double? GiakhuonUSD { get; set; }
        public double? GiakhuonBGUSD { get; set; }
        [MaxLength(20)]
        public string? MaTC { get; set; }
        [MaxLength(100)]
        public string? TenTC { get; set; }
        public bool? Choncokhuon { get; set; }
        [MaxLength(20)]
        public string? Machungtu { get; set; }
        public int? Loaiphieu { get; set; }
        public bool? Ngoaite { get; set; }
        public int? Tigia { get; set; }
        [MaxLength(20)]
        public string? Makhuon { get; set; }
        [MaxLength(100)]
        public string? Tenkhuon { get; set; }
        public double? CPSX { get; set; }
        public int? Socavkhuon { get; set; }
        [MaxLength(20)]
        public string? CreateBy { get; set; }
     
        [MaxLength(20)]
        public string? EditBy { get; set; }
        public DateTime? EditDate { get; set; }
        public int? Trangthai { get; set; }
      
        public DateTime? Ngaychungtu { get; set; }
        public double? Giasp1 { get; set; }
        public double? Giasp2 { get; set; }
        public double? Giasp3 { get; set; }
        public double? Giasp4 { get; set; }
        public double? Giasp5 { get; set; }
        public double? Giathanh { get; set; }
        public double? Baogia { get; set; }
        public double? Moq { get; set; }
        [MaxLength(100)]
        public string? Tenfile { get; set; }
        [MaxLength(20)]
        public string? Chungtugoc { get; set; }
        public virtual ObservableCollectionListSource<PhieudinhgiaCT>PhieudinhgiaCTs { get; set; }    
    }

}
