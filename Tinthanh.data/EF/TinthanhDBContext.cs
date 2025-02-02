
using Microsoft.EntityFrameworkCore;
using Tinthanh.Data.Configurations;
using Tinthanh.Data.Entities;

namespace Tinthanh.Data.EF
{
    public class TinthanhDBContext : DbContext
    {
        public TinthanhDBContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<BanggiaKH> BanggiaKHs { get; set; }
        public DbSet<BanggiaNCC> BanggiaNCCs { get; set; }
        public DbSet<Banggiale> Banggiales { get; set; }

        public DbSet<Danhmuc> Danhmucs { get; set; }
        public DbSet<Loaidanhdiem> Loaidanhdiems { get; set; }
        public DbSet<Nhomdanhdiem> Nhomdanhdiems { get; set; }
        public DbSet<Loaidoituong> Loaiddoituongs { get; set; }
        public DbSet<Nhomdoituong> Nhomdoituongs { get; set; }
        public DbSet<Donvi> Donvis { get; set; }
        public DbSet<Vattu> Vattus { get; set; }
        public DbSet<Taisan> Taisans { get; set; }
        public DbSet<Donvisanpham> Donvisanphams { get; set; }
        public DbSet<Tailieu> Tailieus { get; set; }
        public DbSet<DanhmucCT>DanhmucCTs { get; set; }
        public DbSet<Thanhpham> Thanhphams { get; set; }
        
            
        public DbSet<Khuvuc> Khuvucs { get; set; }
        public DbSet<DateDim> DateDims { get; set; }
        public DbSet<Loaitaisan> Loaitaisans { get; set; }
        public DbSet<Nhomtaisan> Nhomtaisans { get; set; }
        public DbSet<Bophan> Bophans { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<User_CT> UserCTs { get; set; }
        public DbSet<Chucnang> Chucnangs { get; set; }
        public DbSet<KhuonCT> KhuonCTs { get; set; }
        public DbSet<KhuonBG> KhuonBGs { get; set; }
        public DbSet<Xemay> Xemays { get; set; }
        public DbSet<XeHoatdong> XeHoatdongs { get; set; }
        public DbSet<XeBaoTri> XeBaoTris { get; set; }
        public DbSet<MaymocTB> MaymocTBs { get; set; }
        public DbSet<Khuon> Khuons { get; set; }
        public DbSet<ThanhphamBG> ThanhphamBGs { get; set; }
        public DbSet<Dangkiem> Dangkiems { get; set; }
        public DbSet<Khomay> Khomays { get; set; }
        public DbSet<CongviecBT> CongviecBTs { get; set; }
        public DbSet<DanhmucKT> DanhmucKTs { get; set; }
        public DbSet<Hethong> Hethongs { get; set; }
        public DbSet<TieuchiKT> TieuchiKTs { get; set; }
        public DbSet<TieuchiCT> TieuchiCTs { get; set; }

        public DbSet<Khachhang> Khachhangs { get; set; }
        public DbSet<Kho> Khos { get; set; }
        public DbSet<Nganhang> Nganhangs { get; set; }
        public DbSet<Nhacungcap> Nhacungcaps { get; set; }
        public DbSet<KhachhangTN> KhachhangTNs { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            foreach (var property in modelBuilder.Model.GetEntityTypes()
                 .SelectMany(t => t.GetProperties())
                 .Where(p => p.ClrType == typeof(string)))
            {
                property.SetMaxLength(50);
                //   property.IsNullable = true;
            }

            //Configure using Fluent API
            modelBuilder.ApplyConfiguration(new BanggiaKHConfig());
            modelBuilder.ApplyConfiguration(new BanggialeConfig());
            modelBuilder.ApplyConfiguration(new BanggiaNCCConfig());
            modelBuilder.ApplyConfiguration(new DanhmucConfig());
            modelBuilder.ApplyConfiguration(new LoaidanhdiemConfig());
            modelBuilder.ApplyConfiguration(new LoaiddoituongConfig());
            modelBuilder.ApplyConfiguration(new NhomdanhdiemConfig());
            modelBuilder.ApplyConfiguration(new NhomdoituongConfig());
            modelBuilder.ApplyConfiguration(new TailieuConfig());
            modelBuilder.ApplyConfiguration(new LienlacConfig());
            modelBuilder.ApplyConfiguration(new DonviConfig());

            modelBuilder.ApplyConfiguration(new TaisanConfig());
            modelBuilder.ApplyConfiguration(new DonvisanphamConfig());
            modelBuilder.ApplyConfiguration(new KhuvucConfig());
            modelBuilder.ApplyConfiguration(new DateDimConfig());
            modelBuilder.ApplyConfiguration(new LoaitaisanConfig());
            modelBuilder.ApplyConfiguration(new NhomtaisanConfig());
            modelBuilder.ApplyConfiguration(new BophanConfig());
            modelBuilder.ApplyConfiguration(new UserConfig());
            modelBuilder.ApplyConfiguration(new UserCTConfig());
            modelBuilder.ApplyConfiguration(new ChucnangConfig());
            modelBuilder.ApplyConfiguration(new DangkiemConfig());
            modelBuilder.ApplyConfiguration(new ThanhphamConfig());
            modelBuilder.ApplyConfiguration(new ThanhphamBGConfig());
            modelBuilder.ApplyConfiguration(new VattuConfig());
            modelBuilder.ApplyConfiguration(new KhachhangConfig());
            modelBuilder.ApplyConfiguration(new NhacungcapConfig());
            modelBuilder.ApplyConfiguration(new XemayConfig());
            modelBuilder.ApplyConfiguration(new XebaotriConfig());
            modelBuilder.ApplyConfiguration(new XeHoatdongConfig());
            modelBuilder.ApplyConfiguration(new MaymocTBConfig());
            modelBuilder.ApplyConfiguration(new KhuonConfig());
            modelBuilder.ApplyConfiguration(new KhuonCTConfig());
            modelBuilder.ApplyConfiguration(new KhuonBGConfig());

            modelBuilder.ApplyConfiguration(new CongviecBTConfig());
            modelBuilder.ApplyConfiguration(new KhomayConfig());
            modelBuilder.ApplyConfiguration(new DanhmucKTConfig());
            modelBuilder.ApplyConfiguration(new KhachhangConfig());
            modelBuilder.ApplyConfiguration(new KhachhangTNConfig());
            modelBuilder.ApplyConfiguration(new NhacungcapConfig());
            modelBuilder.ApplyConfiguration(new NganhangConfig());
            modelBuilder.ApplyConfiguration(new KhoConfig());

            modelBuilder.ApplyConfiguration(new TieuchiCTConfig());

        }

    }
}
