CREATE DATABASE [QLXemPhim]
GO

USE [QLXemPhim]
GO
ALTER TABLE [dbo].[Trailer] DROP CONSTRAINT [FK_Trailer_Phim]
GO
ALTER TABLE [dbo].[ThongKeDoanhThu] DROP CONSTRAINT [FK_ThongKeDoanhThu_Admin]
GO
ALTER TABLE [dbo].[TapPhim] DROP CONSTRAINT [FK_TapPhim_Phim]
GO
ALTER TABLE [dbo].[TaiKhoan] DROP CONSTRAINT [FK_TaiKhoan_PhanQuyen]
GO
ALTER TABLE [dbo].[TaiKhoan] DROP CONSTRAINT [FK_TaiKhoan_LoaiTaiKhoan]
GO
ALTER TABLE [dbo].[QC_Phim] DROP CONSTRAINT [FK_QC_Phim_QuangCao]
GO
ALTER TABLE [dbo].[QC_Phim] DROP CONSTRAINT [FK_QC_Phim_Phim]
GO
ALTER TABLE [dbo].[Phim] DROP CONSTRAINT [FK_Phim_Trailer]
GO
ALTER TABLE [dbo].[Phim] DROP CONSTRAINT [FK_Phim_TheLoai]
GO
ALTER TABLE [dbo].[Phim] DROP CONSTRAINT [FK_Phim_QuocGia]
GO
ALTER TABLE [dbo].[Phim] DROP CONSTRAINT [FK_Phim_BanQuyenPhim]
GO
ALTER TABLE [dbo].[LichSuXemPhim] DROP CONSTRAINT [FK_LichSuXemPhim_TapPhim]
GO
ALTER TABLE [dbo].[LichSuXemPhim] DROP CONSTRAINT [FK_LichSuXemPhim_TaiKhoan]
GO
ALTER TABLE [dbo].[KhachHang] DROP CONSTRAINT [FK_KhachHang_TaiKhoan]
GO
ALTER TABLE [dbo].[DonMuaPhimLe] DROP CONSTRAINT [FK_DonMuaPhimLe_Voucher]
GO
ALTER TABLE [dbo].[DonMuaPhimLe] DROP CONSTRAINT [FK_DonMuaPhimLe_TaiKhoan]
GO
ALTER TABLE [dbo].[DonMuaPhimLe] DROP CONSTRAINT [FK_DonMuaPhimLe_Phim]
GO
ALTER TABLE [dbo].[DonMuaGoiPhim] DROP CONSTRAINT [FK_DonMuaGoiPhim_Voucher]
GO
ALTER TABLE [dbo].[DonMuaGoiPhim] DROP CONSTRAINT [FK_DonMuaGoiPhim_TaiKhoan]
GO
ALTER TABLE [dbo].[DonMuaGoiPhim] DROP CONSTRAINT [FK_DonMuaGoiPhim_KhachHang]
GO
ALTER TABLE [dbo].[DonMuaGoiPhim] DROP CONSTRAINT [FK_DonMuaGoiPhim_GoiPhim]
GO
ALTER TABLE [dbo].[DienVien_Phim] DROP CONSTRAINT [FK_DienVien_Phim_Phim]
GO
ALTER TABLE [dbo].[DienVien_Phim] DROP CONSTRAINT [FK_DienVien_Phim_DienVien]
GO
ALTER TABLE [dbo].[ChuDe_Phim] DROP CONSTRAINT [FK_ChuDe_Phim_Phim]
GO
ALTER TABLE [dbo].[ChuDe_Phim] DROP CONSTRAINT [FK_ChuDe_Phim_ChuDe]
GO
ALTER TABLE [dbo].[ChiTietDonMuaLe] DROP CONSTRAINT [FK_ChiTietDonMuaLe_Voucher]
GO
ALTER TABLE [dbo].[ChiTietDonMuaLe] DROP CONSTRAINT [FK_ChiTietDonMuaLe_TaiKhoan]
GO
ALTER TABLE [dbo].[ChiTietDonMuaLe] DROP CONSTRAINT [FK_ChiTietDonMuaLe_Phim]
GO
ALTER TABLE [dbo].[ChiTietDonMuaLe] DROP CONSTRAINT [FK_ChiTietDonMuaLe_KhachHang1]
GO
ALTER TABLE [dbo].[ChiTietDonMuaLe] DROP CONSTRAINT [FK_ChiTietDonMuaLe_DonMuaPhimLe1]
GO
ALTER TABLE [dbo].[BinhLuan] DROP CONSTRAINT [FK_BinhLuan_TaiKhoan]
GO
ALTER TABLE [dbo].[BinhLuan] DROP CONSTRAINT [FK_BinhLuan_Phim]
GO
ALTER TABLE [dbo].[Admin] DROP CONSTRAINT [FK_Admin_TaiKhoan]
GO
/****** Object:  Table [dbo].[Voucher]    Script Date: 29/10/2022 9:46:31 CH ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Voucher]') AND type in (N'U'))
DROP TABLE [dbo].[Voucher]
GO
/****** Object:  Table [dbo].[Trailer]    Script Date: 29/10/2022 9:46:31 CH ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Trailer]') AND type in (N'U'))
DROP TABLE [dbo].[Trailer]
GO
/****** Object:  Table [dbo].[ThongKeDoanhThu]    Script Date: 29/10/2022 9:46:31 CH ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ThongKeDoanhThu]') AND type in (N'U'))
DROP TABLE [dbo].[ThongKeDoanhThu]
GO
/****** Object:  Table [dbo].[TheLoai]    Script Date: 29/10/2022 9:46:31 CH ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TheLoai]') AND type in (N'U'))
DROP TABLE [dbo].[TheLoai]
GO
/****** Object:  Table [dbo].[TapPhim]    Script Date: 29/10/2022 9:46:31 CH ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TapPhim]') AND type in (N'U'))
DROP TABLE [dbo].[TapPhim]
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 29/10/2022 9:46:31 CH ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TaiKhoan]') AND type in (N'U'))
DROP TABLE [dbo].[TaiKhoan]
GO
/****** Object:  Table [dbo].[QuocGia]    Script Date: 29/10/2022 9:46:31 CH ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[QuocGia]') AND type in (N'U'))
DROP TABLE [dbo].[QuocGia]
GO
/****** Object:  Table [dbo].[QuangCao]    Script Date: 29/10/2022 9:46:31 CH ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[QuangCao]') AND type in (N'U'))
DROP TABLE [dbo].[QuangCao]
GO
/****** Object:  Table [dbo].[QC_Phim]    Script Date: 29/10/2022 9:46:31 CH ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[QC_Phim]') AND type in (N'U'))
DROP TABLE [dbo].[QC_Phim]
GO
/****** Object:  Table [dbo].[Phim]    Script Date: 29/10/2022 9:46:31 CH ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Phim]') AND type in (N'U'))
DROP TABLE [dbo].[Phim]
GO
/****** Object:  Table [dbo].[PhanQuyen]    Script Date: 29/10/2022 9:46:31 CH ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PhanQuyen]') AND type in (N'U'))
DROP TABLE [dbo].[PhanQuyen]
GO
/****** Object:  Table [dbo].[LoaiTaiKhoan]    Script Date: 29/10/2022 9:46:31 CH ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LoaiTaiKhoan]') AND type in (N'U'))
DROP TABLE [dbo].[LoaiTaiKhoan]
GO
/****** Object:  Table [dbo].[LichSuXemPhim]    Script Date: 29/10/2022 9:46:31 CH ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LichSuXemPhim]') AND type in (N'U'))
DROP TABLE [dbo].[LichSuXemPhim]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 29/10/2022 9:46:31 CH ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[KhachHang]') AND type in (N'U'))
DROP TABLE [dbo].[KhachHang]
GO
/****** Object:  Table [dbo].[GoiPhim]    Script Date: 29/10/2022 9:46:31 CH ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GoiPhim]') AND type in (N'U'))
DROP TABLE [dbo].[GoiPhim]
GO
/****** Object:  Table [dbo].[DonMuaPhimLe]    Script Date: 29/10/2022 9:46:31 CH ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DonMuaPhimLe]') AND type in (N'U'))
DROP TABLE [dbo].[DonMuaPhimLe]
GO
/****** Object:  Table [dbo].[DonMuaGoiPhim]    Script Date: 29/10/2022 9:46:31 CH ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DonMuaGoiPhim]') AND type in (N'U'))
DROP TABLE [dbo].[DonMuaGoiPhim]
GO
/****** Object:  Table [dbo].[DienVien_Phim]    Script Date: 29/10/2022 9:46:31 CH ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DienVien_Phim]') AND type in (N'U'))
DROP TABLE [dbo].[DienVien_Phim]
GO
/****** Object:  Table [dbo].[DienVien]    Script Date: 29/10/2022 9:46:31 CH ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DienVien]') AND type in (N'U'))
DROP TABLE [dbo].[DienVien]
GO
/****** Object:  Table [dbo].[ChuDe_Phim]    Script Date: 29/10/2022 9:46:31 CH ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ChuDe_Phim]') AND type in (N'U'))
DROP TABLE [dbo].[ChuDe_Phim]
GO
/****** Object:  Table [dbo].[ChuDe]    Script Date: 29/10/2022 9:46:31 CH ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ChuDe]') AND type in (N'U'))
DROP TABLE [dbo].[ChuDe]
GO
/****** Object:  Table [dbo].[ChiTietDonMuaLe]    Script Date: 29/10/2022 9:46:31 CH ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ChiTietDonMuaLe]') AND type in (N'U'))
DROP TABLE [dbo].[ChiTietDonMuaLe]
GO
/****** Object:  Table [dbo].[BinhLuan]    Script Date: 29/10/2022 9:46:31 CH ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BinhLuan]') AND type in (N'U'))
DROP TABLE [dbo].[BinhLuan]
GO
/****** Object:  Table [dbo].[BanQuyenPhim]    Script Date: 29/10/2022 9:46:31 CH ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BanQuyenPhim]') AND type in (N'U'))
DROP TABLE [dbo].[BanQuyenPhim]
GO
/****** Object:  Table [dbo].[Admin]    Script Date: 29/10/2022 9:46:31 CH ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Admin]') AND type in (N'U'))
DROP TABLE [dbo].[Admin]
GO
/****** Object:  Table [dbo].[Admin]    Script Date: 29/10/2022 9:46:31 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Admin](
	[MaAdmin] [smallint] IDENTITY(1,1) NOT NULL,
	[HoTen] [nvarchar](250) NULL,
	[MaTaiKhoan] [smallint] NULL,
 CONSTRAINT [PK_Admin] PRIMARY KEY CLUSTERED 
(
	[MaAdmin] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BanQuyenPhim]    Script Date: 29/10/2022 9:46:32 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BanQuyenPhim](
	[MaHopDong] [smallint] IDENTITY(1,1) NOT NULL,
	[ChiTietHopDong] [nvarchar](max) NULL,
	[GiaPhimBanQuyen] [money] NULL,
 CONSTRAINT [PK_BanQuyenPhim] PRIMARY KEY CLUSTERED 
(
	[MaHopDong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BinhLuan]    Script Date: 29/10/2022 9:46:32 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BinhLuan](
	[MaBinhLuan] [smallint] IDENTITY(1,1) NOT NULL,
	[MaTaiKhoan] [smallint] NULL,
	[MaPhim] [smallint] NULL,
	[NoiDungBinhLuan] [nvarchar](max) NULL,
	[ThoiGian] [smalldatetime] NULL,
 CONSTRAINT [PK_BinhLuan] PRIMARY KEY CLUSTERED 
(
	[MaBinhLuan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietDonMuaLe]    Script Date: 29/10/2022 9:46:32 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietDonMuaLe](
	[MaChiTiet] [smallint] IDENTITY(1,1) NOT NULL,
	[MaDonMuaLe] [smallint] NULL,
	[MaTaiKhoan] [smallint] NULL,
	[MaKhachHang] [smallint] NULL,
	[TenPhim] [nvarchar](250) NULL,
	[LoaiPhim] [nvarchar](250) NULL,
	[ChuDe] [nvarchar](250) NULL,
	[NgayDatPhim] [smalldatetime] NULL,
	[TongDonGia] [money] NULL,
	[TrangThai] [bit] NULL,
	[MaPhim] [smallint] NULL,
	[MaVoucher] [nvarchar](50) NULL,
 CONSTRAINT [PK_ChiTietDonMuaLe] PRIMARY KEY CLUSTERED 
(
	[MaChiTiet] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChuDe]    Script Date: 29/10/2022 9:46:32 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChuDe](
	[MaChuDe] [smallint] IDENTITY(1,1) NOT NULL,
	[TenChuDe] [nvarchar](150) NULL,
 CONSTRAINT [PK_ChuDe] PRIMARY KEY CLUSTERED 
(
	[MaChuDe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChuDe_Phim]    Script Date: 29/10/2022 9:46:32 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChuDe_Phim](
	[MaChuDe] [smallint] NOT NULL,
	[MaPhim] [smallint] NOT NULL,
	[MoTa] [nvarchar](max) NULL,
 CONSTRAINT [PK_ChuDe_Phim] PRIMARY KEY CLUSTERED 
(
	[MaChuDe] ASC,
	[MaPhim] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DienVien]    Script Date: 29/10/2022 9:46:32 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DienVien](
	[MaDienVien] [smallint] IDENTITY(1,1) NOT NULL,
	[TenDienVien] [nvarchar](250) NULL,
	[ThongTin] [nvarchar](max) NULL,
 CONSTRAINT [PK_DienVien] PRIMARY KEY CLUSTERED 
(
	[MaDienVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DienVien_Phim]    Script Date: 29/10/2022 9:46:32 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DienVien_Phim](
	[MaDienVien] [smallint] NOT NULL,
	[MaPhim] [smallint] NOT NULL,
 CONSTRAINT [PK_DienVien_Phim] PRIMARY KEY CLUSTERED 
(
	[MaDienVien] ASC,
	[MaPhim] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DonMuaGoiPhim]    Script Date: 29/10/2022 9:46:32 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DonMuaGoiPhim](
	[MaDonMuaGoi] [smallint] IDENTITY(1,1) NOT NULL,
	[MaTaiKhoan] [smallint] NULL,
	[MaKhachHang] [smallint] NULL,
	[MaGoiPhim] [smallint] NULL,
	[ThoiGian] [smalldatetime] NULL,
	[TongTien] [money] NULL,
	[TrangThai] [bit] NULL,
	[MaVoucher] [nvarchar](50) NULL,
 CONSTRAINT [PK_DonMuaGoiPhim] PRIMARY KEY CLUSTERED 
(
	[MaDonMuaGoi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DonMuaPhimLe]    Script Date: 29/10/2022 9:46:32 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DonMuaPhimLe](
	[MaDonMuaLe] [smallint] IDENTITY(1,1) NOT NULL,
	[MaTaiKhoan] [smallint] NULL,
	[MaPhim] [smallint] NULL,
	[TenPhim] [nvarchar](250) NULL,
	[TongDonGia] [money] NULL,
	[MaVoucher] [nvarchar](50) NULL,
 CONSTRAINT [PK_DonMuaPhimLe] PRIMARY KEY CLUSTERED 
(
	[MaDonMuaLe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GoiPhim]    Script Date: 29/10/2022 9:46:32 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GoiPhim](
	[MaGoiPhim] [smallint] IDENTITY(1,1) NOT NULL,
	[LoaiGoiPhim] [nvarchar](150) NULL,
	[DonGia] [money] NULL,
 CONSTRAINT [PK_GoiPhim] PRIMARY KEY CLUSTERED 
(
	[MaGoiPhim] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 29/10/2022 9:46:32 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKhachHang] [smallint] IDENTITY(1,1) NOT NULL,
	[MaTaiKhoan] [smallint] NULL,
	[TenKhachHang] [nvarchar](250) NULL,
	[Tuoi] [tinyint] NULL,
	[email] [nvarchar](150) NULL,
	[sdt] [int] NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[MaKhachHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LichSuXemPhim]    Script Date: 29/10/2022 9:46:32 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LichSuXemPhim](
	[MaTaiKhoan] [smallint] NOT NULL,
	[MaTapPhim] [smallint] NOT NULL,
	[NgayXem] [smalldatetime] NULL,
	[ThoiGianXem] [smalldatetime] NULL,
 CONSTRAINT [PK_LichSuXemPhim] PRIMARY KEY CLUSTERED 
(
	[MaTaiKhoan] ASC,
	[MaTapPhim] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiTaiKhoan]    Script Date: 29/10/2022 9:46:32 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiTaiKhoan](
	[MaLoaiTK] [smallint] IDENTITY(1,1) NOT NULL,
	[TenLoaiTK] [nvarchar](100) NULL,
 CONSTRAINT [PK_LoaiTaiKhoan] PRIMARY KEY CLUSTERED 
(
	[MaLoaiTK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhanQuyen]    Script Date: 29/10/2022 9:46:32 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhanQuyen](
	[MaPhanQuyen] [smallint] IDENTITY(1,1) NOT NULL,
	[TenPhanQuyen] [nvarchar](100) NULL,
 CONSTRAINT [PK_PhanQuyen] PRIMARY KEY CLUSTERED 
(
	[MaPhanQuyen] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Phim]    Script Date: 29/10/2022 9:46:32 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Phim](
	[MaPhim] [smallint] IDENTITY(1,1) NOT NULL,
	[MaTheLoai] [smallint] NULL,
	[MaTrailer] [smallint] NULL,
	[MaHopDong] [smallint] NULL,
	[TenPhim] [nvarchar](250) NULL,
	[TenDienVien] [nvarchar](250) NULL,
	[HinhAnhPhim] [nvarchar](max) NULL,
	[MoTaPhim] [nvarchar](max) NULL,
	[ThoiLuongPhim] [nchar](10) NULL,
	[NamSanXuat] [smalldatetime] NULL,
	[MaQuocGia] [smallint] NULL,
	[LuotXem] [smallint] NULL,
	[DuongDanURL] [nvarchar](max) NOT NULL,
	[DonGia] [money] NOT NULL,
 CONSTRAINT [PK_Phim] PRIMARY KEY CLUSTERED 
(
	[MaPhim] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QC_Phim]    Script Date: 29/10/2022 9:46:32 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QC_Phim](
	[MaPhim] [smallint] NOT NULL,
	[MaQuangCao] [smallint] NOT NULL,
 CONSTRAINT [PK_QC_Phim] PRIMARY KEY CLUSTERED 
(
	[MaPhim] ASC,
	[MaQuangCao] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QuangCao]    Script Date: 29/10/2022 9:46:32 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QuangCao](
	[MaQuangCao] [smallint] IDENTITY(1,1) NOT NULL,
	[LoaiQuangCao] [nvarchar](150) NULL,
	[TenQuangCao] [nvarchar](250) NULL,
	[DuongDanURL] [nvarchar](max) NULL,
	[ThoiHanQC] [smalldatetime] NULL,
	[GiaHanQC] [smalldatetime] NULL,
	[ThoiLuongQC] [nchar](10) NULL,
 CONSTRAINT [PK_QuangCao] PRIMARY KEY CLUSTERED 
(
	[MaQuangCao] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QuocGia]    Script Date: 29/10/2022 9:46:32 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QuocGia](
	[MaQuocGia] [smallint] IDENTITY(1,1) NOT NULL,
	[TenQuocGia] [nvarchar](150) NULL,
 CONSTRAINT [PK_QuocGia] PRIMARY KEY CLUSTERED 
(
	[MaQuocGia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 29/10/2022 9:46:32 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[MaTaiKhoan] [smallint] IDENTITY(1,1) NOT NULL,
	[Username] [nvarchar](100) NULL,
	[Password] [nvarchar](100) NULL,
	[TrangThai] [bit] NULL,
	[MaLoaiTK] [smallint] NULL,
	[MaPhanQuyen] [smallint] NULL,
 CONSTRAINT [PK_TaiKhoan] PRIMARY KEY CLUSTERED 
(
	[MaTaiKhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TapPhim]    Script Date: 29/10/2022 9:46:32 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TapPhim](
	[MaTapPhim] [smallint] IDENTITY(1,1) NOT NULL,
	[TenTapPhim] [nvarchar](150) NULL,
	[MoTa] [nvarchar](max) NULL,
	[ThoiLuong] [nchar](10) NULL,
	[TrangThai] [bit] NULL,
	[HinhAnh] [nvarchar](max) NULL,
	[DuongDanURL] [nvarchar](max) NULL,
	[MaPhim] [smallint] NULL,
 CONSTRAINT [PK_TapPhim] PRIMARY KEY CLUSTERED 
(
	[MaTapPhim] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TheLoai]    Script Date: 29/10/2022 9:46:32 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TheLoai](
	[MaTheLoai] [smallint] IDENTITY(1,1) NOT NULL,
	[TenTheLoai] [nvarchar](150) NULL,
 CONSTRAINT [PK_TheLoai] PRIMARY KEY CLUSTERED 
(
	[MaTheLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ThongKeDoanhThu]    Script Date: 29/10/2022 9:46:32 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThongKeDoanhThu](
	[MaThongKe] [smallint] IDENTITY(1,1) NOT NULL,
	[NgayThongKe] [smalldatetime] NULL,
	[MaAdmin] [smallint] NULL,
	[SoLuongPhim] [tinyint] NULL,
	[TongSoTien] [money] NULL,
	[TrangThai] [bit] NULL,
 CONSTRAINT [PK_ThongKeDoanhThu] PRIMARY KEY CLUSTERED 
(
	[MaThongKe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Trailer]    Script Date: 29/10/2022 9:46:32 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Trailer](
	[MaTrailer] [smallint] IDENTITY(1,1) NOT NULL,
	[TenTrailer] [nvarchar](250) NULL,
	[HinhAnh] [nvarchar](max) NULL,
	[DuongDanURL] [nvarchar](max) NULL,
	[MaPhim] [smallint] NULL,
 CONSTRAINT [PK_Trailer] PRIMARY KEY CLUSTERED 
(
	[MaTrailer] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Voucher]    Script Date: 29/10/2022 9:46:32 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Voucher](
	[MaVoucher] [nvarchar](50) NOT NULL,
	[TenVoucher] [nvarchar](250) NULL,
	[DieuKien] [nvarchar](250) NULL,
	[NgayApDung] [smalldatetime] NULL,
	[NgayHetHan] [smalldatetime] NULL,
	[TrangThai] [bit] NULL,
 CONSTRAINT [PK_Voucher] PRIMARY KEY CLUSTERED 
(
	[MaVoucher] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Admin]  WITH CHECK ADD  CONSTRAINT [FK_Admin_TaiKhoan] FOREIGN KEY([MaTaiKhoan])
REFERENCES [dbo].[TaiKhoan] ([MaTaiKhoan])
GO
ALTER TABLE [dbo].[Admin] CHECK CONSTRAINT [FK_Admin_TaiKhoan]
GO
ALTER TABLE [dbo].[BinhLuan]  WITH CHECK ADD  CONSTRAINT [FK_BinhLuan_Phim] FOREIGN KEY([MaPhim])
REFERENCES [dbo].[Phim] ([MaPhim])
GO
ALTER TABLE [dbo].[BinhLuan] CHECK CONSTRAINT [FK_BinhLuan_Phim]
GO
ALTER TABLE [dbo].[BinhLuan]  WITH CHECK ADD  CONSTRAINT [FK_BinhLuan_TaiKhoan] FOREIGN KEY([MaTaiKhoan])
REFERENCES [dbo].[TaiKhoan] ([MaTaiKhoan])
GO
ALTER TABLE [dbo].[BinhLuan] CHECK CONSTRAINT [FK_BinhLuan_TaiKhoan]
GO
ALTER TABLE [dbo].[ChiTietDonMuaLe]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietDonMuaLe_DonMuaPhimLe1] FOREIGN KEY([MaDonMuaLe])
REFERENCES [dbo].[DonMuaPhimLe] ([MaDonMuaLe])
GO
ALTER TABLE [dbo].[ChiTietDonMuaLe] CHECK CONSTRAINT [FK_ChiTietDonMuaLe_DonMuaPhimLe1]
GO
ALTER TABLE [dbo].[ChiTietDonMuaLe]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietDonMuaLe_KhachHang1] FOREIGN KEY([MaKhachHang])
REFERENCES [dbo].[KhachHang] ([MaKhachHang])
GO
ALTER TABLE [dbo].[ChiTietDonMuaLe] CHECK CONSTRAINT [FK_ChiTietDonMuaLe_KhachHang1]
GO
ALTER TABLE [dbo].[ChiTietDonMuaLe]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietDonMuaLe_Phim] FOREIGN KEY([MaPhim])
REFERENCES [dbo].[Phim] ([MaPhim])
GO
ALTER TABLE [dbo].[ChiTietDonMuaLe] CHECK CONSTRAINT [FK_ChiTietDonMuaLe_Phim]
GO
ALTER TABLE [dbo].[ChiTietDonMuaLe]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietDonMuaLe_TaiKhoan] FOREIGN KEY([MaTaiKhoan])
REFERENCES [dbo].[TaiKhoan] ([MaTaiKhoan])
GO
ALTER TABLE [dbo].[ChiTietDonMuaLe] CHECK CONSTRAINT [FK_ChiTietDonMuaLe_TaiKhoan]
GO
ALTER TABLE [dbo].[ChiTietDonMuaLe]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietDonMuaLe_Voucher] FOREIGN KEY([MaVoucher])
REFERENCES [dbo].[Voucher] ([MaVoucher])
GO
ALTER TABLE [dbo].[ChiTietDonMuaLe] CHECK CONSTRAINT [FK_ChiTietDonMuaLe_Voucher]
GO
ALTER TABLE [dbo].[ChuDe_Phim]  WITH CHECK ADD  CONSTRAINT [FK_ChuDe_Phim_ChuDe] FOREIGN KEY([MaChuDe])
REFERENCES [dbo].[ChuDe] ([MaChuDe])
GO
ALTER TABLE [dbo].[ChuDe_Phim] CHECK CONSTRAINT [FK_ChuDe_Phim_ChuDe]
GO
ALTER TABLE [dbo].[ChuDe_Phim]  WITH CHECK ADD  CONSTRAINT [FK_ChuDe_Phim_Phim] FOREIGN KEY([MaPhim])
REFERENCES [dbo].[Phim] ([MaPhim])
GO
ALTER TABLE [dbo].[ChuDe_Phim] CHECK CONSTRAINT [FK_ChuDe_Phim_Phim]
GO
ALTER TABLE [dbo].[DienVien_Phim]  WITH CHECK ADD  CONSTRAINT [FK_DienVien_Phim_DienVien] FOREIGN KEY([MaDienVien])
REFERENCES [dbo].[DienVien] ([MaDienVien])
GO
ALTER TABLE [dbo].[DienVien_Phim] CHECK CONSTRAINT [FK_DienVien_Phim_DienVien]
GO
ALTER TABLE [dbo].[DienVien_Phim]  WITH CHECK ADD  CONSTRAINT [FK_DienVien_Phim_Phim] FOREIGN KEY([MaPhim])
REFERENCES [dbo].[Phim] ([MaPhim])
GO
ALTER TABLE [dbo].[DienVien_Phim] CHECK CONSTRAINT [FK_DienVien_Phim_Phim]
GO
ALTER TABLE [dbo].[DonMuaGoiPhim]  WITH CHECK ADD  CONSTRAINT [FK_DonMuaGoiPhim_GoiPhim] FOREIGN KEY([MaGoiPhim])
REFERENCES [dbo].[GoiPhim] ([MaGoiPhim])
GO
ALTER TABLE [dbo].[DonMuaGoiPhim] CHECK CONSTRAINT [FK_DonMuaGoiPhim_GoiPhim]
GO
ALTER TABLE [dbo].[DonMuaGoiPhim]  WITH CHECK ADD  CONSTRAINT [FK_DonMuaGoiPhim_KhachHang] FOREIGN KEY([MaKhachHang])
REFERENCES [dbo].[KhachHang] ([MaKhachHang])
GO
ALTER TABLE [dbo].[DonMuaGoiPhim] CHECK CONSTRAINT [FK_DonMuaGoiPhim_KhachHang]
GO
ALTER TABLE [dbo].[DonMuaGoiPhim]  WITH CHECK ADD  CONSTRAINT [FK_DonMuaGoiPhim_TaiKhoan] FOREIGN KEY([MaTaiKhoan])
REFERENCES [dbo].[TaiKhoan] ([MaTaiKhoan])
GO
ALTER TABLE [dbo].[DonMuaGoiPhim] CHECK CONSTRAINT [FK_DonMuaGoiPhim_TaiKhoan]
GO
ALTER TABLE [dbo].[DonMuaGoiPhim]  WITH CHECK ADD  CONSTRAINT [FK_DonMuaGoiPhim_Voucher] FOREIGN KEY([MaVoucher])
REFERENCES [dbo].[Voucher] ([MaVoucher])
GO
ALTER TABLE [dbo].[DonMuaGoiPhim] CHECK CONSTRAINT [FK_DonMuaGoiPhim_Voucher]
GO
ALTER TABLE [dbo].[DonMuaPhimLe]  WITH CHECK ADD  CONSTRAINT [FK_DonMuaPhimLe_Phim] FOREIGN KEY([MaPhim])
REFERENCES [dbo].[Phim] ([MaPhim])
GO
ALTER TABLE [dbo].[DonMuaPhimLe] CHECK CONSTRAINT [FK_DonMuaPhimLe_Phim]
GO
ALTER TABLE [dbo].[DonMuaPhimLe]  WITH CHECK ADD  CONSTRAINT [FK_DonMuaPhimLe_TaiKhoan] FOREIGN KEY([MaTaiKhoan])
REFERENCES [dbo].[TaiKhoan] ([MaTaiKhoan])
GO
ALTER TABLE [dbo].[DonMuaPhimLe] CHECK CONSTRAINT [FK_DonMuaPhimLe_TaiKhoan]
GO
ALTER TABLE [dbo].[DonMuaPhimLe]  WITH CHECK ADD  CONSTRAINT [FK_DonMuaPhimLe_Voucher] FOREIGN KEY([MaVoucher])
REFERENCES [dbo].[Voucher] ([MaVoucher])
GO
ALTER TABLE [dbo].[DonMuaPhimLe] CHECK CONSTRAINT [FK_DonMuaPhimLe_Voucher]
GO
ALTER TABLE [dbo].[KhachHang]  WITH CHECK ADD  CONSTRAINT [FK_KhachHang_TaiKhoan] FOREIGN KEY([MaTaiKhoan])
REFERENCES [dbo].[TaiKhoan] ([MaTaiKhoan])
GO
ALTER TABLE [dbo].[KhachHang] CHECK CONSTRAINT [FK_KhachHang_TaiKhoan]
GO
ALTER TABLE [dbo].[LichSuXemPhim]  WITH CHECK ADD  CONSTRAINT [FK_LichSuXemPhim_TaiKhoan] FOREIGN KEY([MaTaiKhoan])
REFERENCES [dbo].[TaiKhoan] ([MaTaiKhoan])
GO
ALTER TABLE [dbo].[LichSuXemPhim] CHECK CONSTRAINT [FK_LichSuXemPhim_TaiKhoan]
GO
ALTER TABLE [dbo].[LichSuXemPhim]  WITH CHECK ADD  CONSTRAINT [FK_LichSuXemPhim_TapPhim] FOREIGN KEY([MaTapPhim])
REFERENCES [dbo].[TapPhim] ([MaTapPhim])
GO
ALTER TABLE [dbo].[LichSuXemPhim] CHECK CONSTRAINT [FK_LichSuXemPhim_TapPhim]
GO
ALTER TABLE [dbo].[Phim]  WITH CHECK ADD  CONSTRAINT [FK_Phim_BanQuyenPhim] FOREIGN KEY([MaHopDong])
REFERENCES [dbo].[BanQuyenPhim] ([MaHopDong])
GO
ALTER TABLE [dbo].[Phim] CHECK CONSTRAINT [FK_Phim_BanQuyenPhim]
GO
ALTER TABLE [dbo].[Phim]  WITH CHECK ADD  CONSTRAINT [FK_Phim_QuocGia] FOREIGN KEY([MaQuocGia])
REFERENCES [dbo].[QuocGia] ([MaQuocGia])
GO
ALTER TABLE [dbo].[Phim] CHECK CONSTRAINT [FK_Phim_QuocGia]
GO
ALTER TABLE [dbo].[Phim]  WITH CHECK ADD  CONSTRAINT [FK_Phim_TheLoai] FOREIGN KEY([MaTheLoai])
REFERENCES [dbo].[TheLoai] ([MaTheLoai])
GO
ALTER TABLE [dbo].[Phim] CHECK CONSTRAINT [FK_Phim_TheLoai]
GO
ALTER TABLE [dbo].[Phim]  WITH CHECK ADD  CONSTRAINT [FK_Phim_Trailer] FOREIGN KEY([MaTrailer])
REFERENCES [dbo].[Trailer] ([MaTrailer])
GO
ALTER TABLE [dbo].[Phim] CHECK CONSTRAINT [FK_Phim_Trailer]
GO
ALTER TABLE [dbo].[QC_Phim]  WITH CHECK ADD  CONSTRAINT [FK_QC_Phim_Phim] FOREIGN KEY([MaPhim])
REFERENCES [dbo].[Phim] ([MaPhim])
GO
ALTER TABLE [dbo].[QC_Phim] CHECK CONSTRAINT [FK_QC_Phim_Phim]
GO
ALTER TABLE [dbo].[QC_Phim]  WITH CHECK ADD  CONSTRAINT [FK_QC_Phim_QuangCao] FOREIGN KEY([MaQuangCao])
REFERENCES [dbo].[QuangCao] ([MaQuangCao])
GO
ALTER TABLE [dbo].[QC_Phim] CHECK CONSTRAINT [FK_QC_Phim_QuangCao]
GO
ALTER TABLE [dbo].[TaiKhoan]  WITH CHECK ADD  CONSTRAINT [FK_TaiKhoan_LoaiTaiKhoan] FOREIGN KEY([MaLoaiTK])
REFERENCES [dbo].[LoaiTaiKhoan] ([MaLoaiTK])
GO
ALTER TABLE [dbo].[TaiKhoan] CHECK CONSTRAINT [FK_TaiKhoan_LoaiTaiKhoan]
GO
ALTER TABLE [dbo].[TaiKhoan]  WITH CHECK ADD  CONSTRAINT [FK_TaiKhoan_PhanQuyen] FOREIGN KEY([MaPhanQuyen])
REFERENCES [dbo].[PhanQuyen] ([MaPhanQuyen])
GO
ALTER TABLE [dbo].[TaiKhoan] CHECK CONSTRAINT [FK_TaiKhoan_PhanQuyen]
GO
ALTER TABLE [dbo].[TapPhim]  WITH CHECK ADD  CONSTRAINT [FK_TapPhim_Phim] FOREIGN KEY([MaPhim])
REFERENCES [dbo].[Phim] ([MaPhim])
GO
ALTER TABLE [dbo].[TapPhim] CHECK CONSTRAINT [FK_TapPhim_Phim]
GO
ALTER TABLE [dbo].[ThongKeDoanhThu]  WITH CHECK ADD  CONSTRAINT [FK_ThongKeDoanhThu_Admin] FOREIGN KEY([MaAdmin])
REFERENCES [dbo].[Admin] ([MaAdmin])
GO
ALTER TABLE [dbo].[ThongKeDoanhThu] CHECK CONSTRAINT [FK_ThongKeDoanhThu_Admin]
GO
ALTER TABLE [dbo].[Trailer]  WITH CHECK ADD  CONSTRAINT [FK_Trailer_Phim] FOREIGN KEY([MaPhim])
REFERENCES [dbo].[Phim] ([MaPhim])
GO
ALTER TABLE [dbo].[Trailer] CHECK CONSTRAINT [FK_Trailer_Phim]
GO
