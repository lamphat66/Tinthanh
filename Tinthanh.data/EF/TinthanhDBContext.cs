
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

        public DbSet<Chungtu> Chungtus { get; set; }
        public DbSet<Link> Links { get; set; }
        public DbSet<Nhomdanhdiem> Nhomdanhdiems { get; set; }
        public DbSet<Loaidoituong> Loaiddoituongs { get; set; }
        public DbSet<Nhomdoituong> Nhomdoituongs { get; set; }
        public DbSet<Donvi> Donvis { get; set; }
        public DbSet<Vattu> Vattus { get; set; }
        public DbSet<Hinhvattu> Hinhvattus { get; set; }
        public DbSet<DonviVattu> DonviVattus { get; set; }
        public DbSet<Vattu_Tailieu> Vattu_Tailieus { get; set; }
        public DbSet<Taisan> Taisans { get; set; }
        public DbSet<Donvisanpham> Donvisanphams { get; set; }
        public DbSet<Tailieu> Tailieus { get; set; }
        public DbSet<DanhmucCT>DanhmucCTs { get; set; }
        public DbSet<Thanhpham> Thanhphams { get; set; }
        public DbSet<Thanhpham_Tailieu>Thanhpham_Tailieus { get; set; }

        public DbSet<Khuvuc> Khuvucs { get; set; }
        public DbSet<DateDim> DateDims { get; set; }
        public DbSet<Loaitaisan> Loaitaisans { get; set; }
        public DbSet<Nhomtaisan> Nhomtaisans { get; set; }
        public DbSet<Bophan> Bophans { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<User_CT> UserCTs { get; set; }
        public DbSet<Chucnang> Chucnangs { get; set; }
       
        public DbSet<Xemay> Xemays { get; set; }
        public DbSet<XeHoatdong> XeHoatdongs { get; set; }
        public DbSet<XeBaoTri> XeBaoTris { get; set; }
        public DbSet<MaymocTB> MaymocTBs { get; set; }
        public DbSet<Khuon> Khuons { get; set; }
        public DbSet<KhuonCT> KhuonCTs { get; set; }
        public DbSet<KhuonBG> KhuonBGs { get; set; }
        public DbSet<Khuon_Tailieu> Khuon_Tailieus { get; set; }
        public DbSet<ThanhphamBG> ThanhphamBGs { get; set; }
        public DbSet<Dangkiem> Dangkiems { get; set; }
        public DbSet<Khomay> Khomays { get; set; }
        public DbSet<CongviecBT> CongviecBTs { get; set; }
        public DbSet<DanhmucKT> DanhmucKTs { get; set; }
        public DbSet<Hethong> Hethongs { get; set; }
        public DbSet<TieuchiKT> TieuchiKTs { get; set; }
        public DbSet<TieuchiCT> TieuchiCTs { get; set; }

        public DbSet<Khachhang> Khachhangs { get; set; }
        public DbSet<LienlacKH> LienlacKHs { get; set; }
        public DbSet<Khachhang_Tailieu> Khachhang_Tailieus { get; set; }
        public DbSet<Kho> Khos { get; set; }
        public DbSet<Nganhang> Nganhangs { get; set; }
        public DbSet<Nhacungcap> Nhacungcaps { get; set; }
        public DbSet<LienlacNCC> LienlacNCCs { get; set; }
        public DbSet<NhaCC_Tailieu> NhaCC_Tailieus { get; set; }
        
        public DbSet<KhachhangTN> KhachhangTNs { get; set; }
        //Chung tu
        public DbSet<Phieuyeucau> Phieuyeucaus { get; set; }

        public DbSet<PhieuyeucauCT> PhieuyeucauCTs { get; set; }

        public DbSet<Phieuxuly> Phieuxulys { get; set; }

        public DbSet<PhieuxulyCT> PhieuxulyCTs { get; set; }
        public DbSet<Phieudinhgia> Phieudinhgias { get; set; }

        public DbSet<PhieudinhgiaCT> PhieudinhgiaCTs { get; set; }
        public DbSet<Phieubaogia> Phieubaogias { get; set; }

        public DbSet<PhieubaogiaCT> PhieubaogiaCTs { get; set; }
        public DbSet<Phieuthukhuon> Phieuthukhuons { get; set; }
        public DbSet<ThongtinSP> ThongtinSPs { get; set; }
        public DbSet<ThongtinSP_CT> ThongtinSP_CTs { get; set; }
        public DbSet<YeucauGCK> YeucauGCKs { get; set; }
        public DbSet<YeucauGCK_CT> YeucauGCK_CTs { get; set; }
        public DbSet<Hopdongkhuon> Hopdongkhuons { get; set; }
        public DbSet<HopdongkhuonCT> HopdongkhuonCTs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            foreach (var property in modelBuilder.Model.GetEntityTypes()
                 .SelectMany(t => t.GetProperties())
                 .Where(p => p.ClrType == typeof(string)))
            {
                property.SetMaxLength(50);
                //   property.IsNullable = true;
            }
            // dinh nghia View
            modelBuilder.Entity<KhachHangGD>(entity =>
            {
                entity.ToView("KhachHangGD");
                entity.HasKey(e => e.Ma);
            });


            modelBuilder.Entity<ThanhphamGD>(entity =>
            {
                entity.ToView("ThanhphamGD");
                entity.HasKey(e => e.Ma);
            });



            //Configure using Fluent API
            modelBuilder.ApplyConfiguration(new BanggiaKHConfig());
            modelBuilder.ApplyConfiguration(new BanggialeConfig());
            modelBuilder.ApplyConfiguration(new BanggiaNCCConfig());
            modelBuilder.ApplyConfiguration(new DanhmucConfig());
            modelBuilder.ApplyConfiguration(new DanhmucCTConfig());
            modelBuilder.ApplyConfiguration(new LoaidanhdiemConfig());
            modelBuilder.ApplyConfiguration(new LoaiddoituongConfig());
            modelBuilder.ApplyConfiguration(new NhomdanhdiemConfig());
            modelBuilder.ApplyConfiguration(new NhomdoituongConfig());
            modelBuilder.ApplyConfiguration(new TailieuConfig());
            modelBuilder.ApplyConfiguration(new ChungtuConfig());
            modelBuilder.ApplyConfiguration(new LinkConfig());


            modelBuilder.ApplyConfiguration(new DonviConfig());

            modelBuilder.ApplyConfiguration(new TaisanConfig());
            
          
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
            modelBuilder.ApplyConfiguration(new ThanhphamTailieuConfig());
            modelBuilder.ApplyConfiguration(new ThanhphamBGConfig());
            modelBuilder.ApplyConfiguration(new DonvisanphamConfig());

            modelBuilder.ApplyConfiguration(new VattuConfig());
            modelBuilder.ApplyConfiguration(new VattuTailieuConfig());
            modelBuilder.ApplyConfiguration(new DonviVattuConfig());
            modelBuilder.ApplyConfiguration(new HinhvattuConfig());
            
            modelBuilder.ApplyConfiguration(new XemayConfig());
            modelBuilder.ApplyConfiguration(new XebaotriConfig());
            modelBuilder.ApplyConfiguration(new XeHoatdongConfig());
            modelBuilder.ApplyConfiguration(new MaymocTBConfig());
           
            modelBuilder.ApplyConfiguration(new KhuonConfig());
            modelBuilder.ApplyConfiguration(new KhuonCTConfig());
            modelBuilder.ApplyConfiguration(new KhuonBGConfig());
            modelBuilder.ApplyConfiguration(new KhuonTailieuConfig());
            
            modelBuilder.ApplyConfiguration(new CongviecBTConfig());
            modelBuilder.ApplyConfiguration(new KhomayConfig());
            modelBuilder.ApplyConfiguration(new DanhmucKTConfig());
          
            modelBuilder.ApplyConfiguration(new KhachhangConfig());
            modelBuilder.ApplyConfiguration(new KhachhangTailieuConfig());
            modelBuilder.ApplyConfiguration(new KhachhangTNConfig());
            modelBuilder.ApplyConfiguration(new LienlacKHConfig());

            modelBuilder.ApplyConfiguration(new NhacungcapConfig());
            modelBuilder.ApplyConfiguration(new LienlacNhaCCConfig());
            modelBuilder.ApplyConfiguration(new NhaCCTailieuConfig());
            
            modelBuilder.ApplyConfiguration(new NganhangConfig());
            modelBuilder.ApplyConfiguration(new KhoConfig());

            modelBuilder.ApplyConfiguration(new TieuchiCTConfig());

            //Chung tu
            modelBuilder.ApplyConfiguration(new Phieuyeucaucf());
            modelBuilder.ApplyConfiguration(new PhieuyeucauCTcf());
            modelBuilder.ApplyConfiguration(new Phieuxulycf());
            modelBuilder.ApplyConfiguration(new PhieuxulyCTcf());
            modelBuilder.ApplyConfiguration(new Phieudinhgiacf());
            modelBuilder.ApplyConfiguration(new PhieudinhgiaCTcf());
            modelBuilder.ApplyConfiguration(new Phieubaogiacf());
            modelBuilder.ApplyConfiguration(new PhieubaogiaCTcf());
            modelBuilder.ApplyConfiguration(new PhieuthukhuonConfig());
            modelBuilder.ApplyConfiguration(new ThongtinSPConfig());
            modelBuilder.ApplyConfiguration(new ThongtinSPCTConfig());
            modelBuilder.ApplyConfiguration(new YeucauGCKConfig());
            modelBuilder.ApplyConfiguration(new YeucauGCK_CTConfig());
            modelBuilder.ApplyConfiguration(new HopdongkhuonConfig());
            modelBuilder.ApplyConfiguration(new HopdongkhuonCTConfig());

        }

    }
}
