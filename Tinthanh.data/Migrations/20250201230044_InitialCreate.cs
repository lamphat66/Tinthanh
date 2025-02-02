using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tinthanh.data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BanggiaKH",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Makh = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Masp = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Marieng = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Donvi = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    TenSPKH = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    TenSPTT = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Giaban = table.Column<double>(type: "float", nullable: true),
                    Giabannt = table.Column<double>(type: "float", nullable: true),
                    Giacu = table.Column<double>(type: "float", nullable: true),
                    GiacuNT = table.Column<double>(type: "float", nullable: true),
                    Trongluong = table.Column<double>(type: "float", nullable: true),
                    Matdo = table.Column<double>(type: "float", nullable: true),
                    Khomay = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    SoCAV = table.Column<int>(type: "int", nullable: true),
                    Users = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Ngaygiagoc = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Ngaycapnhat = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Giaao = table.Column<double>(type: "float", nullable: true),
                    Giale = table.Column<double>(type: "float", nullable: true),
                    Trangthai = table.Column<short>(type: "smallint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BanggiaKH", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Banggiale",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Masp = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TenSP = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Donvi = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Giaban = table.Column<float>(type: "real", nullable: true),
                    Khomay = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Matdo = table.Column<float>(type: "real", nullable: true),
                    Users = table.Column<float>(type: "real", maxLength: 20, nullable: true),
                    NgayUpdate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Banggiale", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BanggiaNCC",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaDT = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    MaVT = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Donvi = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    TenVT = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    TenNB = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Giaban = table.Column<double>(type: "float", nullable: true),
                    Chietkhau = table.Column<double>(type: "float", nullable: true),
                    TienChietKhau = table.Column<double>(type: "float", nullable: true),
                    Giacu = table.Column<double>(type: "float", nullable: true),
                    NgayUpdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ROHS = table.Column<bool>(type: "bit", nullable: true),
                    Baohanh = table.Column<int>(type: "int", nullable: true),
                    Ghichu = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Hoadon = table.Column<bool>(type: "bit", nullable: true),
                    Users = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ChietkhauSP = table.Column<double>(type: "float", nullable: true),
                    VAT = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BanggiaNCC", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Bophan",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ma = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Ten = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Thuoc = table.Column<int>(type: "int", nullable: true),
                    Truongbophan = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Sanxuat = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bophan", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Chucnang",
                columns: table => new
                {
                    Ma = table.Column<int>(type: "int", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Thuoc = table.Column<int>(type: "int", nullable: true),
                    IsCaption = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chucnang", x => x.Ma);
                });

            migrationBuilder.CreateTable(
                name: "Congviec_BT",
                columns: table => new
                {
                    Ma = table.Column<int>(type: "int", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Ngungsd = table.Column<bool>(type: "bit", nullable: true),
                    IsValue = table.Column<bool>(type: "bit", nullable: true),
                    Dungcu = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Baotrixe = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Congviec_BT", x => x.Ma);
                });

            migrationBuilder.CreateTable(
                name: "Dangkiem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Madt = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Soct = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Ngayct = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Giatri = table.Column<double>(type: "float", nullable: true),
                    Nhacc = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Loai = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Ngaydenhan = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Tennhacc = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    Ngungsd = table.Column<bool>(type: "bit", nullable: true),
                    Tailieu = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true),
                    Sohieu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dangkiem", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Danhmuc_KT",
                columns: table => new
                {
                    Ma = table.Column<int>(type: "int", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Chuanmuc = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Tansuat = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Phuongphap = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Thuchien = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Ngungsd = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Danhmuc_KT", x => x.Ma);
                });

            migrationBuilder.CreateTable(
                name: "DateDim",
                columns: table => new
                {
                    TheDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TheDay = table.Column<int>(type: "int", nullable: true),
                    TheDayName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TheDayOfWeek = table.Column<int>(type: "int", nullable: true),
                    TheDayOfWeekInMonth = table.Column<byte>(type: "tinyint", nullable: true),
                    TheDayOfYear = table.Column<int>(type: "int", nullable: true),
                    IsWeekend = table.Column<int>(type: "int", nullable: false),
                    TheWeek = table.Column<int>(type: "int", nullable: true),
                    TheFirstOfWeek = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TheLastOfWeek = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TheWeekOfMonth = table.Column<byte>(type: "tinyint", nullable: true),
                    TheMonth = table.Column<int>(type: "int", nullable: true),
                    TheMonthName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TheFirstOfMonth = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TheLastOfMonth = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TheFirstOfNextMonth = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TheLastOfNextMonth = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TheQuarter = table.Column<int>(type: "int", nullable: true),
                    TheFirstOfQuarter = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TheLastOfQuarter = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TheYear = table.Column<int>(type: "int", nullable: true),
                    TheFirstOfYear = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TheLastOfYear = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsLeapYear = table.Column<bool>(type: "bit", nullable: true),
                    Has53Weeks = table.Column<int>(type: "int", nullable: false),
                    MMYYYY = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Style101 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Style103 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Style112 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Style120 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DateDim", x => x.TheDate);
                });

            migrationBuilder.CreateTable(
                name: "Donvi",
                columns: table => new
                {
                    Ma = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Ngungsd = table.Column<bool>(type: "bit", nullable: true, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Donvi", x => x.Ma);
                });

            migrationBuilder.CreateTable(
                name: "Hethong",
                columns: table => new
                {
                    Macty = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Tencty = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Diachi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Dienthoai = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Masothue = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    KSDenngay = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SongayKS = table.Column<int>(type: "int", nullable: true),
                    Version = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hethong", x => x.Macty);
                });

            migrationBuilder.CreateTable(
                name: "Khachhang",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ma = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Tentat = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Manhom = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Msthue = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Dienthoai = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Website = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Ngungsd = table.Column<bool>(type: "bit", nullable: true),
                    Ngayngungsd = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Ghichu = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Users = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    EditDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Taikhoan = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Diachi = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Thuoc = table.Column<int>(type: "int", nullable: true),
                    Makv = table.Column<int>(type: "int", maxLength: 20, nullable: true),
                    Soducongno = table.Column<double>(type: "float", nullable: true),
                    Donhang = table.Column<double>(type: "float", nullable: true),
                    Dagiao = table.Column<double>(type: "float", nullable: true),
                    PTVanchuyen = table.Column<int>(type: "int", nullable: true),
                    Lienhe = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Loaicn = table.Column<int>(type: "int", nullable: true),
                    HanTT = table.Column<int>(type: "int", nullable: true),
                    TileTT = table.Column<int>(type: "int", nullable: true),
                    Ketu = table.Column<int>(type: "int", nullable: true),
                    Songay = table.Column<int>(type: "int", nullable: true),
                    TheodoiCN = table.Column<bool>(type: "bit", nullable: true),
                    Maxno = table.Column<double>(type: "float", nullable: true),
                    LinkNhaCC = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Hoadon = table.Column<bool>(type: "bit", nullable: true),
                    Ingia = table.Column<bool>(type: "bit", nullable: true),
                    ThanhtoanNH = table.Column<bool>(type: "bit", nullable: true),
                    Congty = table.Column<bool>(type: "bit", nullable: true),
                    Thuongxuyen = table.Column<bool>(type: "bit", nullable: true),
                    VAT = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Khachhang", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KhachhangTN",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ma = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    Dienthoai = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Website = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Ngungsd = table.Column<bool>(type: "bit", nullable: true),
                    Ngayngungsd = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Users = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    EditDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Diachi = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Lienhe = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhachhangTN", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Kho",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ma = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Tentat = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Manhom = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Dienthoai = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Ngungsd = table.Column<bool>(type: "bit", nullable: true),
                    Ngayngungsd = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Users = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    EditDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Taikhoan = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Diachi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Kho_ao = table.Column<bool>(type: "bit", nullable: true),
                    vitri = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kho", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Khomay",
                columns: table => new
                {
                    Ma = table.Column<int>(type: "int", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true),
                    Loinhuan = table.Column<double>(type: "float", nullable: true),
                    Giakhuon = table.Column<double>(type: "float", nullable: true),
                    GiakhuonUSD = table.Column<double>(type: "float", nullable: true),
                    LoinhuanM = table.Column<double>(type: "float", nullable: true),
                    Ngungsd = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Khomay", x => x.Ma);
                });

            migrationBuilder.CreateTable(
                name: "Khuon",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ma = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Tentat = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Manhom = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    SanluongBT = table.Column<float>(type: "real", nullable: true),
                    SongayBT = table.Column<short>(type: "smallint", nullable: true),
                    Trongluong = table.Column<float>(type: "real", nullable: true),
                    Khomay = table.Column<int>(type: "int", nullable: true),
                    SoCav = table.Column<short>(type: "smallint", nullable: true),
                    Make = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Chuky = table.Column<short>(type: "smallint", nullable: true),
                    TGlenkhuon = table.Column<short>(type: "smallint", nullable: true),
                    TGxuongkhuon = table.Column<short>(type: "smallint", nullable: true),
                    Ghichu = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Makh = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    TenKH = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Tilevon = table.Column<short>(type: "smallint", nullable: true),
                    SanluonggiaKH = table.Column<float>(type: "real", nullable: true),
                    ThoigiangiaKH = table.Column<float>(type: "real", nullable: true),
                    Ngungsd = table.Column<bool>(type: "bit", nullable: true),
                    Mats = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Users = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "getdate()"),
                    EditDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Khuon", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KhuonBG",
                columns: table => new
                {
                    Ma = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EditBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    EditDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Ngungsd = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhuonBG", x => x.Ma);
                });

            migrationBuilder.CreateTable(
                name: "Khuvuc",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ma = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    Ngoainuoc = table.Column<bool>(type: "bit", nullable: true),
                    Macu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Khuvuc", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Loaidanhdiem",
                columns: table => new
                {
                    Ma = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Loaidanhdiem", x => x.Ma);
                });

            migrationBuilder.CreateTable(
                name: "Loaidoituong",
                columns: table => new
                {
                    Ma = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Loaidoituong", x => x.Ma);
                });

            migrationBuilder.CreateTable(
                name: "Loaitaisan",
                columns: table => new
                {
                    Ma = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Loaitaisan", x => x.Ma);
                });

            migrationBuilder.CreateTable(
                name: "MaymocTB",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ma = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Tentat = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Manhom = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    NhaSX = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    NamSX = table.Column<int>(type: "int", nullable: false),
                    Sohieu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NuocSX = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Baotri = table.Column<bool>(type: "bit", nullable: true),
                    NgaySD = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Ghichu = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    NgayngungSD = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EditDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Users = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "getdate()"),
                    Kiemdinh = table.Column<bool>(type: "bit", nullable: true),
                    Hanbaohanh = table.Column<DateTime>(type: "datetime2", nullable: true),
                    HanbaotriDB = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Ngungsd = table.Column<bool>(type: "bit", nullable: true),
                    Model = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Thongso = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    sochetao = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Trongluong = table.Column<short>(type: "smallint", nullable: true),
                    Taitrong = table.Column<float>(type: "real", nullable: true),
                    Congdung = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Soxacnhan = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Bienlai = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Nghiemnhat = table.Column<bool>(type: "bit", nullable: true),
                    Vitri = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Xuatdau = table.Column<bool>(type: "bit", nullable: true),
                    Mats = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Baotringoai = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaymocTB", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Nganhang",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ma = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    Tentat = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Manhom = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Msthue = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Dienthoai = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Website = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Ngungsd = table.Column<bool>(type: "bit", nullable: true),
                    Ngayngungsd = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Users = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    EditDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Diachi = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nganhang", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Nhacungcap",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ma = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Tentat = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Manhom = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Msthue = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Dienthoai = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Website = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Ngungsd = table.Column<bool>(type: "bit", nullable: true),
                    Ngayngungsd = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Ghichu = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Users = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreateBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    EditDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Soducongno = table.Column<double>(type: "float", nullable: true),
                    Donhang = table.Column<double>(type: "float", nullable: true),
                    Dagiao = table.Column<double>(type: "float", nullable: true),
                    Taikhoan = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Diachi = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    PTVanchuyen = table.Column<int>(type: "int", nullable: true),
                    HanTT = table.Column<int>(type: "int", nullable: true),
                    TileTT = table.Column<int>(type: "int", nullable: true),
                    TheodoiCN = table.Column<bool>(type: "bit", nullable: true),
                    Maxno = table.Column<double>(type: "float", nullable: true),
                    ISO = table.Column<bool>(type: "bit", nullable: true),
                    Linkkh = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Hoadon = table.Column<bool>(type: "bit", nullable: true),
                    ThanhtoanNH = table.Column<bool>(type: "bit", nullable: true),
                    VAT = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nhacungcap", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tailieu",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tenfile = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Ngay = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Phanloai = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Mota = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Madt = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Ngungsd = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "getdate()"),
                    Nhomtaileu = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tailieu", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Taisan",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ma = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    Tentat = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Bophansd = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Manhom = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    TGKhauhao = table.Column<int>(type: "int", nullable: true),
                    GiatriKH = table.Column<float>(type: "real", nullable: true),
                    NgungKH = table.Column<bool>(type: "bit", nullable: true),
                    GiatriKHLK = table.Column<float>(type: "real", nullable: true),
                    Nguongoc = table.Column<int>(type: "int", nullable: true),
                    NgayhetKH = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Ngaythanhly = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Giatrithanhly = table.Column<float>(type: "real", nullable: true),
                    Tinhtrang = table.Column<int>(type: "int", nullable: true),
                    NgaySD = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Ghichu = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Loaits = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    TileKH = table.Column<float>(type: "real", nullable: true),
                    Nguyengia = table.Column<float>(type: "real", nullable: true),
                    TKNguyengia = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TKKhauhao = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NgaybatdauKH = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NgayngungSD = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Ngungsd = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    Users = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "getdate()"),
                    EditDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Mats = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TenTS = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Hachtoan = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Taisan", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Thanhpham",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ma = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Tentat = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Manhom = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Ngungsd = table.Column<bool>(type: "bit", nullable: true),
                    Ngayngungsd = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Ghichu = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Users = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EditDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TKkho = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TKphi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Donvi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Ban = table.Column<bool>(type: "bit", nullable: true),
                    Mua = table.Column<bool>(type: "bit", nullable: true),
                    Ton = table.Column<bool>(type: "bit", nullable: true),
                    Dai = table.Column<double>(type: "float", nullable: true),
                    Rong = table.Column<double>(type: "float", nullable: true),
                    Cao = table.Column<double>(type: "float", nullable: true),
                    Trongluong = table.Column<double>(type: "float", nullable: true),
                    Thetich = table.Column<double>(type: "float", nullable: true),
                    Tonmax = table.Column<double>(type: "float", nullable: true),
                    Tonmin = table.Column<double>(type: "float", nullable: true),
                    Cohinh = table.Column<bool>(type: "bit", nullable: true),
                    Quycach = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Tonreq = table.Column<double>(type: "float", nullable: true),
                    Tinhgia = table.Column<int>(type: "int", nullable: true),
                    Kho = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Mabo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Hesobo = table.Column<double>(type: "float", nullable: true),
                    Titrong = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Thanhpham", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ThanhphamBG",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ma = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Donvi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Users = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EditDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Ngungsd = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThanhphamBG", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TieuchiKT",
                columns: table => new
                {
                    Ma = table.Column<int>(type: "int", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TieuchiKT", x => x.Ma);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Ma = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Bophan = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Ngaytao = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "getdate()"),
                    Locked = table.Column<bool>(type: "bit", nullable: true),
                    IsSuperUser = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Ma);
                });

            migrationBuilder.CreateTable(
                name: "Vattu",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ma = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Tentat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Manhom = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Macu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ngungsd = table.Column<bool>(type: "bit", nullable: true),
                    Ngayngungsd = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Ghichu = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Users = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EditDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TKkho = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TKphi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Donvi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ban = table.Column<bool>(type: "bit", nullable: true),
                    Mua = table.Column<bool>(type: "bit", nullable: true),
                    Ton = table.Column<bool>(type: "bit", nullable: true),
                    Dai = table.Column<double>(type: "float", nullable: true),
                    Rong = table.Column<double>(type: "float", nullable: true),
                    Cao = table.Column<double>(type: "float", nullable: true),
                    Trongluong = table.Column<double>(type: "float", nullable: true),
                    Thetich = table.Column<double>(type: "float", nullable: true),
                    Tonmax = table.Column<double>(type: "float", nullable: true),
                    Tonmin = table.Column<double>(type: "float", nullable: true),
                    TieuchiKT = table.Column<int>(type: "int", nullable: true),
                    Quycach = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Xuatxu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nhapkhau = table.Column<bool>(type: "bit", nullable: true),
                    Tonreq = table.Column<double>(type: "float", nullable: true),
                    Kho = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Titrong = table.Column<double>(type: "float", nullable: true),
                    Loainhua = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vattu", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Xemay",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ma = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Tentat = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Manhom = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    NhaSX = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    NamSX = table.Column<int>(type: "int", nullable: false),
                    NuocSX = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Baotri = table.Column<bool>(type: "bit", nullable: true),
                    NgaySD = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Trongluong = table.Column<short>(type: "smallint", nullable: true),
                    Bienso = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Kiemdinh = table.Column<bool>(type: "bit", nullable: true),
                    Baohiem = table.Column<bool>(type: "bit", nullable: true),
                    Mabuchi = table.Column<bool>(type: "bit", nullable: true),
                    Model = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Socho = table.Column<short>(type: "smallint", nullable: true),
                    Taitrong = table.Column<double>(type: "float", nullable: true),
                    Namdangky = table.Column<int>(type: "int", nullable: false),
                    Namhethan = table.Column<int>(type: "int", nullable: false),
                    Somay = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Loaithung = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Thetichthung = table.Column<double>(type: "float", nullable: true),
                    Kichthuocthung = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Sokhung = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Hancavet = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Dinhmucdau = table.Column<double>(type: "float", nullable: true),
                    Xegiaohang = table.Column<bool>(type: "bit", nullable: true),
                    HanbaotriDB = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Hanbaohanh = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Ghichu = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    NgayngungSD = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EditBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    EditDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreateBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "getdate()"),
                    Ngungsd = table.Column<bool>(type: "bit", nullable: true),
                    Xuatdau = table.Column<bool>(type: "bit", nullable: true),
                    Mats = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Xemay", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LienlacKH",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Hoten = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Dienthoai = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Chucvu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Bophan = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    KhachhangId = table.Column<int>(type: "int", nullable: true),
                    Chinhanh = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    EInvoice = table.Column<bool>(type: "bit", nullable: true),
                    Quyetdinh = table.Column<bool>(type: "bit", nullable: true),
                    Ngungsd = table.Column<bool>(type: "bit", nullable: true),
                    Didong = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Diachi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Phanloai = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PhanloaiId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LienlacKH", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LienlacKH_Khachhang_KhachhangId",
                        column: x => x.KhachhangId,
                        principalTable: "Khachhang",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Khuon_CT",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Masp = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    TenSP = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    Socav = table.Column<short>(type: "smallint", nullable: true),
                    Donvi = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    SPchinh = table.Column<bool>(type: "bit", nullable: true),
                    DaiD = table.Column<double>(type: "float", nullable: true),
                    DaiA = table.Column<double>(type: "float", nullable: true),
                    RongD = table.Column<double>(type: "float", nullable: true),
                    RongA = table.Column<double>(type: "float", nullable: true),
                    CaoD = table.Column<double>(type: "float", nullable: true),
                    CaoA = table.Column<double>(type: "float", nullable: true),
                    Daint = table.Column<double>(type: "float", nullable: true),
                    Rongnt = table.Column<double>(type: "float", nullable: true),
                    Caont = table.Column<double>(type: "float", nullable: true),
                    Daispd = table.Column<double>(type: "float", nullable: true),
                    Daispa = table.Column<double>(type: "float", nullable: true),
                    Rongspd = table.Column<double>(type: "float", nullable: true),
                    Rongspa = table.Column<double>(type: "float", nullable: true),
                    Caospa = table.Column<double>(type: "float", nullable: true),
                    KhuonId = table.Column<int>(type: "int", nullable: true),
                    Nhom = table.Column<int>(type: "int", nullable: true),
                    Caospd = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Khuon_CT", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Khuon_CT_Khuon_KhuonId",
                        column: x => x.KhuonId,
                        principalTable: "Khuon",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Nhomdanhdiem",
                columns: table => new
                {
                    Ma = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    Madd = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Ngungsd = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nhomdanhdiem", x => x.Ma);
                    table.ForeignKey(
                        name: "FK_Nhomdanhdiem_Loaidanhdiem_Madd",
                        column: x => x.Madd,
                        principalTable: "Loaidanhdiem",
                        principalColumn: "Ma",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Nhomdoituong",
                columns: table => new
                {
                    Ma = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    Madt = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Ngungsd = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nhomdoituong", x => x.Ma);
                    table.ForeignKey(
                        name: "FK_Nhomdoituong_Loaidoituong_Madt",
                        column: x => x.Madt,
                        principalTable: "Loaidoituong",
                        principalColumn: "Ma",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Nhomtaisan",
                columns: table => new
                {
                    Ma = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    Mats = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Ngungsd = table.Column<bool>(type: "bit", nullable: true, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nhomtaisan", x => x.Ma);
                    table.ForeignKey(
                        name: "FK_Nhomtaisan_Loaitaisan_Mats",
                        column: x => x.Mats,
                        principalTable: "Loaitaisan",
                        principalColumn: "Ma");
                });

            migrationBuilder.CreateTable(
                name: "LienlacNCC",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Hoten = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Dienthoai = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Chucvu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Bophan = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Ma = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Chinhanh = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    EInvoice = table.Column<bool>(type: "bit", nullable: true),
                    Quyetdinh = table.Column<bool>(type: "bit", nullable: true),
                    Ngungsd = table.Column<bool>(type: "bit", nullable: true),
                    NhacungcapId = table.Column<int>(type: "int", nullable: false),
                    Didong = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Diachi = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Phanloai = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PhanloaiId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LienlacNCC", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LienlacNCC_Nhacungcap_NhacungcapId",
                        column: x => x.NhacungcapId,
                        principalTable: "Nhacungcap",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Donvisanpham",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Donvi = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Heso = table.Column<double>(type: "float", nullable: true),
                    Trongluong = table.Column<double>(type: "float", nullable: true),
                    Dongia = table.Column<double>(type: "float", nullable: true),
                    Ngungsd = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    ThanhphamId = table.Column<int>(type: "int", nullable: false),
                    Giakho = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Donvisanpham", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Donvisanpham_Thanhpham_ThanhphamId",
                        column: x => x.ThanhphamId,
                        principalTable: "Thanhpham",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TieuchiCT",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaKT = table.Column<int>(type: "int", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TieuchiKTMa = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TieuchiCT", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TieuchiCT_TieuchiKT_TieuchiKTMa",
                        column: x => x.TieuchiKTMa,
                        principalTable: "TieuchiKT",
                        principalColumn: "Ma",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "User_CT",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsersMa = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    MenuId = table.Column<int>(type: "int", nullable: false),
                    TenMenu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Quyen = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User_CT", x => x.Id);
                    table.ForeignKey(
                        name: "FK_User_CT_Users_UsersMa",
                        column: x => x.UsersMa,
                        principalTable: "Users",
                        principalColumn: "Ma",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DonviVattu",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Donvi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Heso = table.Column<double>(type: "float", nullable: true),
                    Trongluong = table.Column<double>(type: "float", nullable: true),
                    Ngungsd = table.Column<bool>(type: "bit", nullable: true),
                    VattuId = table.Column<int>(type: "int", nullable: true),
                    Dongia = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DonviVattu", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DonviVattu_Vattu_VattuId",
                        column: x => x.VattuId,
                        principalTable: "Vattu",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Xe_Baotri",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    XemayId = table.Column<int>(type: "int", nullable: false),
                    Sokm = table.Column<int>(type: "int", nullable: true),
                    Sogio = table.Column<double>(type: "float", nullable: true),
                    Congviec = table.Column<int>(type: "int", nullable: true),
                    Ghichu = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Hinhthuc = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Sokmdau = table.Column<double>(type: "float", nullable: true),
                    Sogiodau = table.Column<int>(type: "int", nullable: true),
                    Soxe = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Xe_Baotri", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Xe_Baotri_Xemay_XemayId",
                        column: x => x.XemayId,
                        principalTable: "Xemay",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Xe_Hoatdong",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    XemayId = table.Column<int>(type: "int", nullable: false),
                    Sokm = table.Column<double>(type: "float", nullable: true),
                    Sogio = table.Column<double>(type: "float", nullable: true),
                    Ghichu = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Ngay = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Soxe = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Xe_Hoatdong", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Xe_Hoatdong_Xemay_XemayId",
                        column: x => x.XemayId,
                        principalTable: "Xemay",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BanggiaKH_Masp_Makh",
                table: "BanggiaKH",
                columns: new[] { "Masp", "Makh" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Banggiale_Masp",
                table: "Banggiale",
                column: "Masp",
                unique: true,
                filter: "[Masp] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_BanggiaNCC_MaVT_MaDT",
                table: "BanggiaNCC",
                columns: new[] { "MaVT", "MaDT" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Bophan_Ma",
                table: "Bophan",
                column: "Ma",
                unique: true,
                filter: "[Ma] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Dangkiem",
                table: "Dangkiem",
                column: "Madt");

            migrationBuilder.CreateIndex(
                name: "IX_Donvisanpham_ThanhphamId",
                table: "Donvisanpham",
                column: "ThanhphamId");

            migrationBuilder.CreateIndex(
                name: "IX_DonviVattu_VattuId",
                table: "DonviVattu",
                column: "VattuId");

            migrationBuilder.CreateIndex(
                name: "IX_Khachhang",
                table: "Khachhang",
                column: "Manhom");

            migrationBuilder.CreateIndex(
                name: "IX_Khachhang_Ma",
                table: "Khachhang",
                column: "Ma",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_KhachhangTN_Ma",
                table: "KhachhangTN",
                column: "Ma",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Kho_Ma",
                table: "Kho",
                column: "Ma",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Khuon_Ma",
                table: "Khuon",
                column: "Ma",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Nhomkhuon",
                table: "Khuon",
                column: "Manhom");

            migrationBuilder.CreateIndex(
                name: "IX_Khuon_CT_KhuonId",
                table: "Khuon_CT",
                column: "KhuonId");

            migrationBuilder.CreateIndex(
                name: "IX_Khuvuc_Ma",
                table: "Khuvuc",
                column: "Ma",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_LienlacKH_KhachhangId",
                table: "LienlacKH",
                column: "KhachhangId");

            migrationBuilder.CreateIndex(
                name: "IX_LienlacNCC_NhacungcapId",
                table: "LienlacNCC",
                column: "NhacungcapId");

            migrationBuilder.CreateIndex(
                name: "IX_MaymocTB_Ma",
                table: "MaymocTB",
                column: "Ma",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_NhomMaymoc",
                table: "MaymocTB",
                column: "Manhom");

            migrationBuilder.CreateIndex(
                name: "IX_Nganhang_Ma",
                table: "Nganhang",
                column: "Ma",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Nhacungcap_Ma",
                table: "Nhacungcap",
                column: "Ma",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_NhomNhacungcap",
                table: "Nhacungcap",
                column: "Manhom");

            migrationBuilder.CreateIndex(
                name: "IX_Nhomdanhdiem_Madd",
                table: "Nhomdanhdiem",
                column: "Madd");

            migrationBuilder.CreateIndex(
                name: "IX_Nhomdoituong_Madt",
                table: "Nhomdoituong",
                column: "Madt");

            migrationBuilder.CreateIndex(
                name: "IX_Nhomtaisan_Mats",
                table: "Nhomtaisan",
                column: "Mats");

            migrationBuilder.CreateIndex(
                name: "IX_Nhomtailieu",
                table: "Tailieu",
                column: "Nhomtaileu");

            migrationBuilder.CreateIndex(
                name: "IX_Tailieu",
                table: "Tailieu",
                column: "Madt");

            migrationBuilder.CreateIndex(
                name: "IX_Taisan",
                table: "Taisan",
                column: "Ma",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TaisanNhom",
                table: "Taisan",
                column: "Manhom");

            migrationBuilder.CreateIndex(
                name: "IX_Nhomthanhpham",
                table: "Thanhpham",
                column: "Manhom");

            migrationBuilder.CreateIndex(
                name: "IX_Thanhpham_Ma",
                table: "Thanhpham",
                column: "Ma",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ThanhphamBG_Ma",
                table: "ThanhphamBG",
                column: "Ma",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TieuchiCT_TieuchiKTMa",
                table: "TieuchiCT",
                column: "TieuchiKTMa");

            migrationBuilder.CreateIndex(
                name: "IX_User_CT_UsersMa",
                table: "User_CT",
                column: "UsersMa");

            migrationBuilder.CreateIndex(
                name: "IX_NhomVattu",
                table: "Vattu",
                column: "Manhom");

            migrationBuilder.CreateIndex(
                name: "IX_Vattu_Ma",
                table: "Vattu",
                column: "Ma",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Xe_Baotri_XemayId",
                table: "Xe_Baotri",
                column: "XemayId");

            migrationBuilder.CreateIndex(
                name: "IX_Xe_Hoatdong_XemayId",
                table: "Xe_Hoatdong",
                column: "XemayId");

            migrationBuilder.CreateIndex(
                name: "IX_NhomXemay",
                table: "Xemay",
                column: "Manhom");

            migrationBuilder.CreateIndex(
                name: "IX_Xemay_Ma",
                table: "Xemay",
                column: "Ma",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BanggiaKH");

            migrationBuilder.DropTable(
                name: "Banggiale");

            migrationBuilder.DropTable(
                name: "BanggiaNCC");

            migrationBuilder.DropTable(
                name: "Bophan");

            migrationBuilder.DropTable(
                name: "Chucnang");

            migrationBuilder.DropTable(
                name: "Congviec_BT");

            migrationBuilder.DropTable(
                name: "Dangkiem");

            migrationBuilder.DropTable(
                name: "Danhmuc_KT");

            migrationBuilder.DropTable(
                name: "DateDim");

            migrationBuilder.DropTable(
                name: "Donvi");

            migrationBuilder.DropTable(
                name: "Donvisanpham");

            migrationBuilder.DropTable(
                name: "DonviVattu");

            migrationBuilder.DropTable(
                name: "Hethong");

            migrationBuilder.DropTable(
                name: "KhachhangTN");

            migrationBuilder.DropTable(
                name: "Kho");

            migrationBuilder.DropTable(
                name: "Khomay");

            migrationBuilder.DropTable(
                name: "Khuon_CT");

            migrationBuilder.DropTable(
                name: "KhuonBG");

            migrationBuilder.DropTable(
                name: "Khuvuc");

            migrationBuilder.DropTable(
                name: "LienlacKH");

            migrationBuilder.DropTable(
                name: "LienlacNCC");

            migrationBuilder.DropTable(
                name: "MaymocTB");

            migrationBuilder.DropTable(
                name: "Nganhang");

            migrationBuilder.DropTable(
                name: "Nhomdanhdiem");

            migrationBuilder.DropTable(
                name: "Nhomdoituong");

            migrationBuilder.DropTable(
                name: "Nhomtaisan");

            migrationBuilder.DropTable(
                name: "Tailieu");

            migrationBuilder.DropTable(
                name: "Taisan");

            migrationBuilder.DropTable(
                name: "ThanhphamBG");

            migrationBuilder.DropTable(
                name: "TieuchiCT");

            migrationBuilder.DropTable(
                name: "User_CT");

            migrationBuilder.DropTable(
                name: "Xe_Baotri");

            migrationBuilder.DropTable(
                name: "Xe_Hoatdong");

            migrationBuilder.DropTable(
                name: "Thanhpham");

            migrationBuilder.DropTable(
                name: "Vattu");

            migrationBuilder.DropTable(
                name: "Khuon");

            migrationBuilder.DropTable(
                name: "Khachhang");

            migrationBuilder.DropTable(
                name: "Nhacungcap");

            migrationBuilder.DropTable(
                name: "Loaidanhdiem");

            migrationBuilder.DropTable(
                name: "Loaidoituong");

            migrationBuilder.DropTable(
                name: "Loaitaisan");

            migrationBuilder.DropTable(
                name: "TieuchiKT");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Xemay");
        }
    }
}
