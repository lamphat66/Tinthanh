using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tinthanh.data.Migrations
{
    /// <inheritdoc />
    public partial class update6th : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Khuon",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValueSql: "getdate()");

            //migrationBuilder.CreateTable(
            //    name: "Hinhvattu",
            //    columns: table => new
            //    {
            //        Mavt = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
            //        Hinhanh = table.Column<byte[]>(type: "varbinary(max)", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Hinhvattu", x => x.Mavt);
            //    });

            migrationBuilder.CreateTable(
                name: "Hopdongkhuon",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Maphieu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Ngaylap = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Ngaychungtu = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Sohopdong = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CopyFrom = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CopyTo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Makh = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Tenkh = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SoSP = table.Column<int>(type: "int", nullable: true),
                    SonamBH = table.Column<int>(type: "int", nullable: true),
                    ThoigianHT = table.Column<int>(type: "int", nullable: true),
                    TWDot1 = table.Column<int>(type: "int", nullable: true),
                    TWDot2 = table.Column<int>(type: "int", nullable: true),
                    CreateBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Hantt = table.Column<int>(type: "int", nullable: true),
                    Ghichu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    EditBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    EditDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GiatriNT = table.Column<double>(type: "float", nullable: true),
                    PathFile = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Bienban = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Trangthai = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hopdongkhuon", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Phieubaogia",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Maphieu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Ngaylap = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Makh = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Tenkh = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Ghichu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Diachi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Nguoilienhe = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Dienthoai = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Hieuluc = table.Column<int>(type: "int", nullable: true),
                    HinhthucTT = table.Column<bool>(type: "bit", nullable: true),
                    HanTT = table.Column<int>(type: "int", nullable: true),
                    PTVanchuyen = table.Column<int>(type: "int", nullable: true),
                    TW1 = table.Column<int>(type: "int", nullable: true),
                    TW2 = table.Column<int>(type: "int", nullable: true),
                    Songaykhuon = table.Column<int>(type: "int", nullable: true),
                    Trangthai = table.Column<int>(type: "int", nullable: true),
                    Solan = table.Column<int>(type: "int", nullable: true),
                    Ngaychungtu = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Ngayduyet = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Ngoaite = table.Column<bool>(type: "bit", nullable: true),
                    DKTT = table.Column<int>(type: "int", nullable: true),
                    ThoihanTT = table.Column<int>(type: "int", nullable: true),
                    Maxno = table.Column<double>(type: "float", nullable: true),
                    TileTT = table.Column<double>(type: "float", nullable: true),
                    SongayLH = table.Column<int>(type: "int", nullable: true),
                    GhichuNB = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Tigia = table.Column<int>(type: "int", nullable: true),
                    CreateBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    EditBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    EditDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CopyFrom = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CopyTo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phieubaogia", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Phieudinhgia",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Maphieu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Ngaylap = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MaSP = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TenSP = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MAKH = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TenKH = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Thetich = table.Column<double>(type: "float", nullable: true),
                    Titrong = table.Column<double>(type: "float", nullable: true),
                    Gia1 = table.Column<double>(type: "float", nullable: true),
                    Gia2 = table.Column<double>(type: "float", nullable: true),
                    Gia3 = table.Column<double>(type: "float", nullable: true),
                    Gia4 = table.Column<double>(type: "float", nullable: true),
                    Gia5 = table.Column<double>(type: "float", nullable: true),
                    Khoiluong = table.Column<double>(type: "float", nullable: true),
                    Sanluong = table.Column<double>(type: "float", nullable: true),
                    SoCAV = table.Column<int>(type: "int", nullable: true),
                    Khomay = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LoinhuanCK = table.Column<double>(type: "float", nullable: true),
                    Dai = table.Column<double>(type: "float", nullable: true),
                    Rong = table.Column<double>(type: "float", nullable: true),
                    Cao = table.Column<double>(type: "float", nullable: true),
                    Logo = table.Column<bool>(type: "bit", nullable: true),
                    Buocgia = table.Column<int>(type: "int", nullable: true),
                    SaisoTT = table.Column<int>(type: "int", nullable: true),
                    SaisoKL = table.Column<int>(type: "int", nullable: true),
                    Giachon = table.Column<double>(type: "float", nullable: true),
                    SLTheo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    GiaSP = table.Column<double>(type: "float", nullable: true),
                    Giakhuon = table.Column<double>(type: "float", nullable: true),
                    Ghichu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Hanthanhtoan = table.Column<int>(type: "int", nullable: true),
                    TGlamkhuon = table.Column<int>(type: "int", nullable: true),
                    GiakhuonBG = table.Column<double>(type: "float", nullable: true),
                    GiakhuonUSD = table.Column<double>(type: "float", nullable: true),
                    GiakhuonBGUSD = table.Column<double>(type: "float", nullable: true),
                    MaTC = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TenTC = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Choncokhuon = table.Column<bool>(type: "bit", nullable: true),
                    Machungtu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Loaiphieu = table.Column<int>(type: "int", nullable: true),
                    Ngoaite = table.Column<bool>(type: "bit", nullable: true),
                    Tigia = table.Column<int>(type: "int", nullable: true),
                    Makhuon = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Tenkhuon = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CPSX = table.Column<double>(type: "float", nullable: true),
                    Socavkhuon = table.Column<int>(type: "int", nullable: true),
                    CreateBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    EditBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    EditDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Trangthai = table.Column<int>(type: "int", nullable: true),
                    Ngaychungtu = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Giasp1 = table.Column<double>(type: "float", nullable: true),
                    Giasp2 = table.Column<double>(type: "float", nullable: true),
                    Giasp3 = table.Column<double>(type: "float", nullable: true),
                    Giasp4 = table.Column<double>(type: "float", nullable: true),
                    Giasp5 = table.Column<double>(type: "float", nullable: true),
                    Giathanh = table.Column<double>(type: "float", nullable: true),
                    Baogia = table.Column<double>(type: "float", nullable: true),
                    Moq = table.Column<double>(type: "float", nullable: true),
                    Tenfile = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CopyFrom = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CopyTo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phieudinhgia", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Phieuthukhuon",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Maphieu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Ngaylap = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Ngaychungtu = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Tinhdien = table.Column<int>(type: "int", nullable: true),
                    Ngaygiao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Slmau = table.Column<int>(type: "int", nullable: true),
                    TGChayDK = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MayKichHat = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MayDinhHinh = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Ngaykichhat = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NgayChaymau = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Tu = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Den = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NVkichhat = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NVvanhanh = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ChuKy = table.Column<int>(type: "int", nullable: true),
                    SLKich = table.Column<float>(type: "real", nullable: true),
                    Loaihat = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TLBadauMax = table.Column<float>(type: "real", nullable: true),
                    TLBadauMin = table.Column<float>(type: "real", nullable: true),
                    TLThanhphamMax = table.Column<float>(type: "real", nullable: true),
                    TLThanhphammin = table.Column<float>(type: "real", nullable: true),
                    Titrong = table.Column<float>(type: "real", nullable: true),
                    SoCK = table.Column<int>(type: "int", nullable: true),
                    SoSP = table.Column<int>(type: "int", nullable: true),
                    TGU = table.Column<int>(type: "int", nullable: true),
                    SPOK = table.Column<int>(type: "int", nullable: true),
                    SPNG = table.Column<int>(type: "int", nullable: true),
                    GhichuKM = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PhieuKT = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Loaibao = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SLBao = table.Column<int>(type: "int", nullable: true),
                    QCngang = table.Column<int>(type: "int", nullable: true),
                    GhichuDG = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    QCD = table.Column<int>(type: "int", nullable: true),
                    QCL = table.Column<int>(type: "int", nullable: true),
                    Tenbao = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TenNhua = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Tenkichhat = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TenDinhhinh = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    GhichuCM = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CopyFrom = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CopyTo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Makhuon = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Tenkhuon = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Trangthai = table.Column<int>(type: "int", nullable: true),
                    DateEdit = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EditBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreateBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phieuthukhuon", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Phieuxuly",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Maphieu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Ngaylap = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Ngaychungtu = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Makh = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Tenkh = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Khomay = table.Column<int>(type: "int", nullable: true),
                    Thoigiangc = table.Column<int>(type: "int", nullable: true),
                    Trangthai = table.Column<int>(type: "int", nullable: true),
                    CreateBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    EditBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    EditDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Ghichu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Giakhuon = table.Column<double>(type: "float", nullable: true),
                    Tenkhuon = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Logo = table.Column<bool>(type: "bit", nullable: true),
                    SoCAV = table.Column<int>(type: "int", maxLength: 20, nullable: true),
                    Bo = table.Column<int>(type: "int", nullable: true),
                    Kiemtra = table.Column<int>(type: "int", nullable: true),
                    Kekhuon = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CopyFrom = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CopyTo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Ngaynhan = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Nguoinhan = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Ngayxl = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Nguoixl = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Ngayvc = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Nguoivc = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phieuxuly", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Phieuyeucau",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Maphieu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Ngaylap = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Ngaychungtu = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Ngayhoanthanh = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Makh = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Tenkh = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Ngaynhan1 = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Nguoinhan1 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NgayVC1 = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NguoiVC1 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NgayXL1 = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NguoiXL1 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Ghichu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Trangthai = table.Column<int>(type: "int", nullable: true),
                    Ketluan = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreateBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    EditBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    EditDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Diachi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Dienthoai = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Lienhe = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CopyFrom = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CopyTo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phieuyeucau", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ThongtinSP",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Maphieu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Ngaylap = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Ngaychungtu = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Makh = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Tenkh = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Khomay = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Ngoaiquan = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Yeucaukhac = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Makhuon = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Tenkhuon = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Kekhuon = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Dautukh = table.Column<double>(type: "float", nullable: true),
                    Dautucty = table.Column<double>(type: "float", nullable: true),
                    Maus = table.Column<bool>(type: "bit", nullable: true),
                    Loaikt = table.Column<int>(type: "int", nullable: true),
                    Logo = table.Column<bool>(type: "bit", nullable: true),
                    CreateBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    EditBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    EditDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Trangthai = table.Column<int>(type: "int", nullable: true),
                    Socav = table.Column<int>(type: "int", nullable: true),
                    Bo = table.Column<int>(type: "int", nullable: true),
                    SLChaymau = table.Column<int>(type: "int", nullable: true),
                    CopyFrom = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CopyTo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThongtinSP", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "YeucauGCK",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Maphieu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Ngaylap = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MaKH = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TenKH = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Makhuon = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Tenkhuon = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BatdauTK = table.Column<DateTime>(type: "datetime2", nullable: true),
                    HoanthanhTK = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GiaomauTK = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BatdauGC = table.Column<DateTime>(type: "datetime2", nullable: true),
                    HoanthanhGC = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GiaomauGC = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Khomay = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SoCAV = table.Column<int>(type: "int", nullable: true),
                    Yeucau = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Machungtu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    KhuonNB = table.Column<bool>(type: "bit", nullable: true),
                    PathFile = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreateBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DateEdit = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EditBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Hinhthuc = table.Column<int>(type: "int", nullable: true),
                    Dinhkem = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Bienban = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Tinhtrang = table.Column<int>(type: "int", nullable: true),
                    Trangthai = table.Column<int>(type: "int", nullable: true),
                    Ngaychungtu = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Ngaynhankhuon = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Ngaythumau = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Ngaygiaokhuon = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Ngayhoanthanh = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CopyFrom = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CopyTo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YeucauGCK", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Hopdongkhuon_CT",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HopdongkhuonId = table.Column<int>(type: "int", nullable: false),
                    Maphieu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Makhuon = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Tenkhuon = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Socav = table.Column<int>(type: "int", nullable: true),
                    Khomay = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Donvi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Dongia = table.Column<double>(type: "float", nullable: true),
                    Thanhtien = table.Column<double>(type: "float", nullable: true),
                    Dongiant = table.Column<double>(type: "float", nullable: true),
                    Thanhtiennt = table.Column<double>(type: "float", nullable: true),
                    Vat = table.Column<int>(type: "int", nullable: true),
                    Soluong = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hopdongkhuon_CT", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Hopdongkhuon_CT_Hopdongkhuon_HopdongkhuonId",
                        column: x => x.HopdongkhuonId,
                        principalTable: "Hopdongkhuon",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Phieubaogia_CT",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PhieubaogiaId = table.Column<int>(type: "int", nullable: false),
                    Stt = table.Column<int>(type: "int", maxLength: 20, nullable: true),
                    Masp = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Tensp = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Donvi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Dongia = table.Column<double>(type: "float", nullable: true),
                    Vat = table.Column<int>(type: "int", nullable: true),
                    Thanhtien = table.Column<double>(type: "float", nullable: true),
                    Trongluong = table.Column<double>(type: "float", nullable: true),
                    Matdo = table.Column<double>(type: "float", nullable: true),
                    Loai = table.Column<int>(type: "int", nullable: true),
                    Socav = table.Column<int>(type: "int", nullable: true),
                    Khomay = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DongiaNT = table.Column<double>(type: "float", nullable: true),
                    ThanhtienNT = table.Column<double>(type: "float", nullable: true),
                    GiaSC = table.Column<double>(type: "float", nullable: true),
                    GiaSCNT = table.Column<double>(type: "float", nullable: true),
                    GiaCu = table.Column<double>(type: "float", nullable: true),
                    GiaCuNT = table.Column<double>(type: "float", nullable: true),
                    DongiaKG = table.Column<double>(type: "float", nullable: true),
                    SoluongBG = table.Column<double>(type: "float", nullable: true),
                    Tilevon = table.Column<double>(type: "float", nullable: true),
                    gc = table.Column<bool>(type: "bit", nullable: true),
                    Mabo = table.Column<int>(type: "int", nullable: true),
                    SoluongKH = table.Column<double>(type: "float", nullable: true),
                    GiaKH = table.Column<double>(type: "float", nullable: true),
                    GiaKH_USD = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phieubaogia_CT", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Phieubaogia_CT_Phieubaogia_PhieubaogiaId",
                        column: x => x.PhieubaogiaId,
                        principalTable: "Phieubaogia",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Phieudinhgia_CT",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PhieudinhgiaId = table.Column<int>(type: "int", nullable: false),
                    Masp = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Tensp = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TT = table.Column<float>(type: "real", nullable: false),
                    V = table.Column<float>(type: "real", nullable: false),
                    TL = table.Column<float>(type: "real", nullable: false),
                    Gia1 = table.Column<float>(type: "real", nullable: false),
                    Gia2 = table.Column<float>(type: "real", nullable: false),
                    Gia3 = table.Column<float>(type: "real", nullable: false),
                    Gia4 = table.Column<float>(type: "real", nullable: false),
                    Gia5 = table.Column<float>(type: "real", nullable: false),
                    D = table.Column<float>(type: "real", nullable: false),
                    R = table.Column<float>(type: "real", nullable: false),
                    C = table.Column<float>(type: "real", nullable: false),
                    SoCAV = table.Column<int>(type: "int", nullable: false),
                    Giathanh = table.Column<float>(type: "real", nullable: false),
                    Baogia = table.Column<float>(type: "real", nullable: false),
                    Moq = table.Column<float>(type: "real", nullable: false),
                    Chon = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phieudinhgia_CT", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Phieudinhgia_CT_Phieudinhgia_PhieudinhgiaId",
                        column: x => x.PhieudinhgiaId,
                        principalTable: "Phieudinhgia",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Phieuxuly_CT",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PhieuxulyId = table.Column<int>(type: "int", nullable: false),
                    Masp = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Tensp = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Thetich = table.Column<double>(type: "float", nullable: true),
                    Titrong = table.Column<double>(type: "float", nullable: true),
                    Trongluong = table.Column<double>(type: "float", nullable: true),
                    Dai = table.Column<double>(type: "float", nullable: true),
                    Rong = table.Column<double>(type: "float", nullable: true),
                    Cao = table.Column<double>(type: "float", nullable: true),
                    Socav = table.Column<int>(type: "int", nullable: true),
                    Donvi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Yeucau = table.Column<int>(type: "int", nullable: true),
                    DaiD = table.Column<double>(type: "float", nullable: true),
                    DaiA = table.Column<double>(type: "float", nullable: true),
                    RongD = table.Column<double>(type: "float", nullable: true),
                    RongA = table.Column<double>(type: "float", nullable: true),
                    CaoD = table.Column<double>(type: "float", nullable: true),
                    CaoA = table.Column<double>(type: "float", nullable: true),
                    daikd = table.Column<double>(type: "float", nullable: true),
                    daika = table.Column<double>(type: "float", nullable: true),
                    rongkd = table.Column<double>(type: "float", nullable: true),
                    rongka = table.Column<double>(type: "float", nullable: true),
                    caokd = table.Column<double>(type: "float", nullable: true),
                    caoka = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phieuxuly_CT", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Phieuxuly_CT_Phieuxuly_PhieuxulyId",
                        column: x => x.PhieuxulyId,
                        principalTable: "Phieuxuly",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Phieuyeucau_CT",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Masp = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Tensp = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Donvi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Soluong = table.Column<int>(type: "int", nullable: true),
                    Khomay = table.Column<int>(type: "int", nullable: true),
                    Ghichu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Ketqua = table.Column<int>(type: "int", nullable: true),
                    Loaisp = table.Column<int>(type: "int", nullable: true),
                    Xuly = table.Column<int>(type: "int", nullable: true),
                    Yeucau = table.Column<int>(type: "int", nullable: true),
                    KhomayKH = table.Column<int>(type: "int", nullable: true),
                    Socav = table.Column<int>(type: "int", nullable: true),
                    SocavT = table.Column<int>(type: "int", nullable: true),
                    Thoihan = table.Column<int>(type: "int", nullable: true),
                    Tinhtrang = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    YeucauT = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    GiaSC = table.Column<double>(type: "float", nullable: true),
                    SoluongDH = table.Column<double>(type: "float", nullable: true),
                    Lanthang = table.Column<int>(type: "int", nullable: true),
                    SoluongMin = table.Column<int>(type: "int", nullable: true),
                    Nhomkhuon = table.Column<int>(type: "int", nullable: true),
                    PhieuyeucauId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phieuyeucau_CT", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Phieuyeucau_CT_Phieuyeucau_PhieuyeucauId",
                        column: x => x.PhieuyeucauId,
                        principalTable: "Phieuyeucau",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ThongtinSP_CT",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaSP = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TenSP = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Dai = table.Column<double>(type: "float", nullable: true),
                    Rong = table.Column<double>(type: "float", nullable: true),
                    Cao = table.Column<double>(type: "float", nullable: true),
                    LoaiSL = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Trongluong = table.Column<double>(type: "float", nullable: true),
                    Titrong = table.Column<double>(type: "float", nullable: true),
                    Thetich = table.Column<double>(type: "float", nullable: true),
                    Sanluong = table.Column<double>(type: "float", nullable: true),
                    DaiD = table.Column<double>(type: "float", nullable: true),
                    DaiA = table.Column<double>(type: "float", nullable: true),
                    RongD = table.Column<double>(type: "float", nullable: true),
                    RongA = table.Column<double>(type: "float", nullable: true),
                    SPChinh = table.Column<bool>(type: "bit", nullable: true),
                    CaoD = table.Column<double>(type: "float", nullable: true),
                    CaoA = table.Column<double>(type: "float", nullable: true),
                    Socav = table.Column<double>(type: "float", nullable: true),
                    daikd = table.Column<double>(type: "float", nullable: true),
                    daika = table.Column<double>(type: "float", nullable: true),
                    rongkd = table.Column<double>(type: "float", nullable: true),
                    rongka = table.Column<double>(type: "float", nullable: true),
                    caokd = table.Column<double>(type: "float", nullable: true),
                    caoka = table.Column<double>(type: "float", nullable: true),
                    ThongtinSPId = table.Column<int>(type: "int", nullable: false),
                    Donvi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThongtinSP_CT", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ThongtinSP_CT_ThongtinSP_ThongtinSPId",
                        column: x => x.ThongtinSPId,
                        principalTable: "ThongtinSP",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "YeucauGCK_CT",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YeucauGCKId = table.Column<int>(type: "int", nullable: false),
                    Tenvt = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Soluong = table.Column<float>(type: "real", nullable: true),
                    Donvi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YeucauGCK_CT", x => x.Id);
                    table.ForeignKey(
                        name: "FK_YeucauGCK_CT_YeucauGCK_YeucauGCKId",
                        column: x => x.YeucauGCKId,
                        principalTable: "YeucauGCK",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
            
            migrationBuilder.CreateTable(
               name: "Sinhma",
               columns: table => new
               {
                   LoaiCT = table.Column<string>(type: "nvarchar(10)", nullable: false),

                   TenCT = table.Column<string>(type: "nvarchar(80)",maxLength: 80, nullable: false),
                   Hauto = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                   Dodai = table.Column<Int16>(type: "tinyint", nullable: true),
                   Bang = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
               },
               constraints: table =>
               {
                   table.PrimaryKey("PK_Sinhma", x => x.LoaiCT);
                   
               });


            migrationBuilder.CreateIndex(
                name: "IX_Hopdongkhuon_Maphieu",
                table: "Hopdongkhuon",
                column: "Maphieu",
                unique: true,
                filter: "[Maphieu] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Hopdongkhuon_CT_HopdongkhuonId",
                table: "Hopdongkhuon_CT",
                column: "HopdongkhuonId");

            migrationBuilder.CreateIndex(
                name: "IX_Phieubaogia_Maphieu",
                table: "Phieubaogia",
                column: "Maphieu",
                unique: true,
                filter: "[Maphieu] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Phieubaogia_CT_PhieubaogiaId",
                table: "Phieubaogia_CT",
                column: "PhieubaogiaId");

            migrationBuilder.CreateIndex(
                name: "IX_Phieudinhgia_Maphieu",
                table: "Phieudinhgia",
                column: "Maphieu",
                unique: true,
                filter: "[Maphieu] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Phieudinhgia_CT_PhieudinhgiaId",
                table: "Phieudinhgia_CT",
                column: "PhieudinhgiaId");

            migrationBuilder.CreateIndex(
                name: "IX_Phieuthukhuon_Maphieu",
                table: "Phieuthukhuon",
                column: "Maphieu",
                unique: true,
                filter: "[Maphieu] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Phieuxuly_Maphieu",
                table: "Phieuxuly",
                column: "Maphieu",
                unique: true,
                filter: "[Maphieu] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Phieuxuly_CT_PhieuxulyId",
                table: "Phieuxuly_CT",
                column: "PhieuxulyId");

            migrationBuilder.CreateIndex(
                name: "IX_Phieuyeucau_Maphieu",
                table: "Phieuyeucau",
                column: "Maphieu",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Phieuyeucau_CT_PhieuyeucauId",
                table: "Phieuyeucau_CT",
                column: "PhieuyeucauId");

            migrationBuilder.CreateIndex(
                name: "IX_ThongtinSP_Maphieu",
                table: "ThongtinSP",
                column: "Maphieu",
                unique: true,
                filter: "[Maphieu] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ThongtinSP_CT_ThongtinSPId",
                table: "ThongtinSP_CT",
                column: "ThongtinSPId");

            migrationBuilder.CreateIndex(
                name: "IX_YeucauGCK_Maphieu",
                table: "YeucauGCK",
                column: "Maphieu",
                unique: true,
                filter: "[Maphieu] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_YeucauGCK_CT_YeucauGCKId",
                table: "YeucauGCK_CT",
                column: "YeucauGCKId");

            migrationBuilder.AddColumn<int>(
               name: "Macu",
               table: "ThanhphamBG",
               type: "nvarchar(20)",
               nullable: true
               );

            migrationBuilder.AddColumn<int>(
               name: "Macu",
               table: "KhuonBG",
               type: "nvarchar(20)",
               nullable: true
               );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropTable(
            //    name: "Hinhvattu");

            migrationBuilder.DropTable(
                name: "Hopdongkhuon_CT");

            migrationBuilder.DropTable(
                name: "Phieubaogia_CT");

            migrationBuilder.DropTable(
                name: "Phieudinhgia_CT");

            migrationBuilder.DropTable(
                name: "Phieuthukhuon");

            migrationBuilder.DropTable(
                name: "Phieuxuly_CT");

            migrationBuilder.DropTable(
                name: "Phieuyeucau_CT");

            migrationBuilder.DropTable(
                name: "ThongtinSP_CT");

            migrationBuilder.DropTable(
                name: "YeucauGCK_CT");

            migrationBuilder.DropTable(
                name: "Hopdongkhuon");

            migrationBuilder.DropTable(
                name: "Phieubaogia");

            migrationBuilder.DropTable(
                name: "Phieudinhgia");

            migrationBuilder.DropTable(
                name: "Phieuxuly");

            migrationBuilder.DropTable(
                name: "Phieuyeucau");

            migrationBuilder.DropTable(
                name: "ThongtinSP");

            migrationBuilder.DropTable(
                name: "YeucauGCK");


            migrationBuilder.DropTable(
                name: "Sinhma");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Khuon",
                type: "datetime2",
                nullable: true,
                defaultValueSql: "getdate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.DropColumn(
                name: "Macu",
                table: "KhuonBG");

            migrationBuilder.DropColumn(
               name: "Macu",
               table: "ThanhphamBG");
        }
    }
}
