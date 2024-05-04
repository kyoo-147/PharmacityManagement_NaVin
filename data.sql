USE [QLThuoc]
GO
/****** Object:  Table [dbo].[ChiNhanh]    Script Date: 11/14/2023 9:00:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiNhanh](
	[MaChiNhanh] [int] IDENTITY(1,1) NOT NULL,
	[TenChiNhanh] [nvarchar](200) NULL,
	[DiaChi] [nvarchar](300) NULL,
	[SoDienThoai] [int] NULL,
	[DaXoa] [bit] NULL,
 CONSTRAINT [PK_ChiNhanh] PRIMARY KEY CLUSTERED 
(
	[MaChiNhanh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ChiTietDon]    Script Date: 11/14/2023 9:00:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietDon](
	[MaCTDT] [int] IDENTITY(1,1) NOT NULL,
	[MaDon] [int] NULL,
	[MaThuoc] [int] NULL,
	[SoLuong] [int] NULL,
	[ThanhTien] [numeric](18, 0) NULL,
	[DaXoa] [bit] NULL,
 CONSTRAINT [PK_ChiTietDon] PRIMARY KEY CLUSTERED 
(
	[MaCTDT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DonNhap]    Script Date: 11/14/2023 9:00:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DonNhap](
	[MaDN] [int] IDENTITY(1,1) NOT NULL,
	[TenNCC] [nvarchar](200) NULL,
	[SoLuong] [int] NULL,
	[TenThuoc] [nvarchar](200) NULL,
	[GiaNhap] [numeric](18, 0) NULL,
	[TongTien] [numeric](18, 0) NULL,
	[DaXoa] [bit] NULL,
 CONSTRAINT [PK_DonNhap] PRIMARY KEY CLUSTERED 
(
	[MaDN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DonThuoc]    Script Date: 11/14/2023 9:00:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DonThuoc](
	[MaDon] [int] IDENTITY(1,1) NOT NULL,
	[NgayLap] [datetime] NULL,
	[MaNV] [int] NULL,
	[DaXoa] [bit] NULL,
	[MaKH] [int] NULL,
	[MaChiNhanh] [int] NULL,
 CONSTRAINT [PK_DonThuoc] PRIMARY KEY CLUSTERED 
(
	[MaDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 11/14/2023 9:00:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKH] [int] IDENTITY(1,1) NOT NULL,
	[TenKH] [nvarchar](200) NULL,
	[DiaChi] [nvarchar](200) NULL,
	[SDT] [nvarchar](50) NULL,
	[DaXoa] [bit] NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LoaiThuoc]    Script Date: 11/14/2023 9:00:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiThuoc](
	[MaLoai] [int] IDENTITY(1,1) NOT NULL,
	[TenLoai] [nvarchar](200) NULL,
	[DaXoa] [bit] NULL,
 CONSTRAINT [PK_LoaiThuoc] PRIMARY KEY CLUSTERED 
(
	[MaLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Login]    Script Date: 11/14/2023 9:00:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Login](
	[TaiKhoan] [nvarchar](200) NOT NULL,
	[MatKhau] [nvarchar](200) NULL,
	[MaNhanVien] [int] NULL,
	[DaXoa] [bit] NULL,
 CONSTRAINT [PK_Login] PRIMARY KEY CLUSTERED 
(
	[TaiKhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhaCungCap]    Script Date: 11/14/2023 9:00:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaCungCap](
	[MaNCC] [int] IDENTITY(1,1) NOT NULL,
	[TenNCC] [nvarchar](200) NULL,
	[DiaChi] [nvarchar](200) NULL,
	[SDT] [nvarchar](50) NULL,
	[DaXoa] [bit] NULL,
 CONSTRAINT [PK_NhaCungCap] PRIMARY KEY CLUSTERED 
(
	[MaNCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 11/14/2023 9:00:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [int] IDENTITY(1,1) NOT NULL,
	[TenNV] [nvarchar](200) NULL,
	[ChucVu] [nvarchar](200) NULL,
	[NgaySinh] [datetime] NULL,
	[DaXoa] [bit] NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Thuoc]    Script Date: 11/14/2023 9:00:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Thuoc](
	[MaThuoc] [int] IDENTITY(1,1) NOT NULL,
	[TenThuoc] [nvarchar](200) NULL,
	[MaLoai] [int] NULL,
	[SoLuong] [int] NULL,
	[GiaBan] [numeric](18, 0) NULL,
	[DVT] [nvarchar](200) NULL,
	[DaXoa] [bit] NULL,
	[MaNCC] [int] NULL,
	[MaDN] [int] NULL,
 CONSTRAINT [PK_Thuoc] PRIMARY KEY CLUSTERED 
(
	[MaThuoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[ChiNhanh] ON 

INSERT [dbo].[ChiNhanh] ([MaChiNhanh], [TenChiNhanh], [DiaChi], [SoDienThoai], [DaXoa]) VALUES (1, N'Trung Son', N'Dong Thap', 328297517, 0)
INSERT [dbo].[ChiNhanh] ([MaChiNhanh], [TenChiNhanh], [DiaChi], [SoDienThoai], [DaXoa]) VALUES (2, N'Long Chau', N'Cao Lanh', 112412312, 0)
INSERT [dbo].[ChiNhanh] ([MaChiNhanh], [TenChiNhanh], [DiaChi], [SoDienThoai], [DaXoa]) VALUES (3, N'Minh Chau', N'Lap Vo', 121231244, 0)
INSERT [dbo].[ChiNhanh] ([MaChiNhanh], [TenChiNhanh], [DiaChi], [SoDienThoai], [DaXoa]) VALUES (4, N'Parmacity', N'HCM', 328297517, 0)
INSERT [dbo].[ChiNhanh] ([MaChiNhanh], [TenChiNhanh], [DiaChi], [SoDienThoai], [DaXoa]) VALUES (5, N'An Khang', N'Quan 5 TPHCM', 123213213, 0)
INSERT [dbo].[ChiNhanh] ([MaChiNhanh], [TenChiNhanh], [DiaChi], [SoDienThoai], [DaXoa]) VALUES (6, N'ECO', N'HCM', 124124144, 0)
INSERT [dbo].[ChiNhanh] ([MaChiNhanh], [TenChiNhanh], [DiaChi], [SoDienThoai], [DaXoa]) VALUES (7, N'Phuong Chinh', N'HCM', 123123213, 0)
INSERT [dbo].[ChiNhanh] ([MaChiNhanh], [TenChiNhanh], [DiaChi], [SoDienThoai], [DaXoa]) VALUES (8, N'My Chau', N'An Giang', 454656122, 0)
SET IDENTITY_INSERT [dbo].[ChiNhanh] OFF
SET IDENTITY_INSERT [dbo].[ChiTietDon] ON 

INSERT [dbo].[ChiTietDon] ([MaCTDT], [MaDon], [MaThuoc], [SoLuong], [ThanhTien], [DaXoa]) VALUES (4, 1, 19, 20, CAST(23000 AS Numeric(18, 0)), 0)
INSERT [dbo].[ChiTietDon] ([MaCTDT], [MaDon], [MaThuoc], [SoLuong], [ThanhTien], [DaXoa]) VALUES (5, 2, 21, 15, CAST(360000 AS Numeric(18, 0)), 0)
INSERT [dbo].[ChiTietDon] ([MaCTDT], [MaDon], [MaThuoc], [SoLuong], [ThanhTien], [DaXoa]) VALUES (6, 3, 20, 16, CAST(32000 AS Numeric(18, 0)), 0)
INSERT [dbo].[ChiTietDon] ([MaCTDT], [MaDon], [MaThuoc], [SoLuong], [ThanhTien], [DaXoa]) VALUES (7, 4, 25, 17, CAST(170000 AS Numeric(18, 0)), 0)
INSERT [dbo].[ChiTietDon] ([MaCTDT], [MaDon], [MaThuoc], [SoLuong], [ThanhTien], [DaXoa]) VALUES (8, 5, 26, 12, CAST(108000 AS Numeric(18, 0)), 0)
INSERT [dbo].[ChiTietDon] ([MaCTDT], [MaDon], [MaThuoc], [SoLuong], [ThanhTien], [DaXoa]) VALUES (65, 2, 22, 12, CAST(120000 AS Numeric(18, 0)), NULL)
INSERT [dbo].[ChiTietDon] ([MaCTDT], [MaDon], [MaThuoc], [SoLuong], [ThanhTien], [DaXoa]) VALUES (66, 1, 26, 12, CAST(120000 AS Numeric(18, 0)), NULL)
INSERT [dbo].[ChiTietDon] ([MaCTDT], [MaDon], [MaThuoc], [SoLuong], [ThanhTien], [DaXoa]) VALUES (67, 2, 21, 14, CAST(140000 AS Numeric(18, 0)), 0)
INSERT [dbo].[ChiTietDon] ([MaCTDT], [MaDon], [MaThuoc], [SoLuong], [ThanhTien], [DaXoa]) VALUES (68, 2, 19, 12, CAST(120000 AS Numeric(18, 0)), 0)
INSERT [dbo].[ChiTietDon] ([MaCTDT], [MaDon], [MaThuoc], [SoLuong], [ThanhTien], [DaXoa]) VALUES (69, 2, 28, 1, CAST(10000 AS Numeric(18, 0)), 0)
INSERT [dbo].[ChiTietDon] ([MaCTDT], [MaDon], [MaThuoc], [SoLuong], [ThanhTien], [DaXoa]) VALUES (70, NULL, 25, 14, NULL, NULL)
INSERT [dbo].[ChiTietDon] ([MaCTDT], [MaDon], [MaThuoc], [SoLuong], [ThanhTien], [DaXoa]) VALUES (71, 2, 21, 1, CAST(10000 AS Numeric(18, 0)), 0)
INSERT [dbo].[ChiTietDon] ([MaCTDT], [MaDon], [MaThuoc], [SoLuong], [ThanhTien], [DaXoa]) VALUES (72, 2, 24, 3, CAST(30000 AS Numeric(18, 0)), 0)
INSERT [dbo].[ChiTietDon] ([MaCTDT], [MaDon], [MaThuoc], [SoLuong], [ThanhTien], [DaXoa]) VALUES (73, 1, 21, 12, CAST(120000 AS Numeric(18, 0)), 0)
INSERT [dbo].[ChiTietDon] ([MaCTDT], [MaDon], [MaThuoc], [SoLuong], [ThanhTien], [DaXoa]) VALUES (74, 1, 23, 15, CAST(150000 AS Numeric(18, 0)), 0)
INSERT [dbo].[ChiTietDon] ([MaCTDT], [MaDon], [MaThuoc], [SoLuong], [ThanhTien], [DaXoa]) VALUES (75, 8, 25, 14, CAST(140000 AS Numeric(18, 0)), 0)
INSERT [dbo].[ChiTietDon] ([MaCTDT], [MaDon], [MaThuoc], [SoLuong], [ThanhTien], [DaXoa]) VALUES (76, 8, 25, 15, CAST(150000 AS Numeric(18, 0)), 0)
SET IDENTITY_INSERT [dbo].[ChiTietDon] OFF
SET IDENTITY_INSERT [dbo].[DonNhap] ON 

INSERT [dbo].[DonNhap] ([MaDN], [TenNCC], [SoLuong], [TenThuoc], [GiaNhap], [TongTien], [DaXoa]) VALUES (1, N'Cong ty duoc Hau Giang', 100, N'Thuốc Efferalgan', CAST(3000 AS Numeric(18, 0)), CAST(300000 AS Numeric(18, 0)), 0)
INSERT [dbo].[DonNhap] ([MaDN], [TenNCC], [SoLuong], [TenThuoc], [GiaNhap], [TongTien], [DaXoa]) VALUES (2, N'Cong ty duoc Traphaco', 1000, N'Curcumin fast', CAST(5000 AS Numeric(18, 0)), CAST(5000000 AS Numeric(18, 0)), 0)
INSERT [dbo].[DonNhap] ([MaDN], [TenNCC], [SoLuong], [TenThuoc], [GiaNhap], [TongTien], [DaXoa]) VALUES (3, N'Cong ty duoc Pymepharco', 50, N'Acetaminophen 500 mg', CAST(4000 AS Numeric(18, 0)), CAST(200000 AS Numeric(18, 0)), 0)
INSERT [dbo].[DonNhap] ([MaDN], [TenNCC], [SoLuong], [TenThuoc], [GiaNhap], [TongTien], [DaXoa]) VALUES (4, N'Cong ty duoc ImexPharm', 250, N'Gentamicin sulfate 80 mg', CAST(6500 AS Numeric(18, 0)), CAST(1625000 AS Numeric(18, 0)), 0)
INSERT [dbo].[DonNhap] ([MaDN], [TenNCC], [SoLuong], [TenThuoc], [GiaNhap], [TongTien], [DaXoa]) VALUES (5, N'Cong ty duoc DOMESCO', 630, N'Omeprazol DOMESCO', CAST(7300 AS Numeric(18, 0)), CAST(2628000 AS Numeric(18, 0)), 0)
INSERT [dbo].[DonNhap] ([MaDN], [TenNCC], [SoLuong], [TenThuoc], [GiaNhap], [TongTien], [DaXoa]) VALUES (6, N'Cong ty duoc Dược phẩm 3/2', 2000, N'Rosuvastatin', CAST(8600 AS Numeric(18, 0)), CAST(17200000 AS Numeric(18, 0)), 0)
INSERT [dbo].[DonNhap] ([MaDN], [TenNCC], [SoLuong], [TenThuoc], [GiaNhap], [TongTien], [DaXoa]) VALUES (7, N'Cong ty duoc Trung ương 1', 2540, N'Digoxin Pharbaco', CAST(8600 AS Numeric(18, 0)), CAST(21844000 AS Numeric(18, 0)), 0)
INSERT [dbo].[DonNhap] ([MaDN], [TenNCC], [SoLuong], [TenThuoc], [GiaNhap], [TongTien], [DaXoa]) VALUES (8, N'Cong ty duoc Trung ương 2', 3645, N'Glucosamine sulfate Pharbaco', CAST(2000 AS Numeric(18, 0)), CAST(7290000 AS Numeric(18, 0)), 0)
INSERT [dbo].[DonNhap] ([MaDN], [TenNCC], [SoLuong], [TenThuoc], [GiaNhap], [TongTien], [DaXoa]) VALUES (9, N'Cong ty duoc Trung ương 3', 400, N'Thuốc ho Pharbaco', CAST(7600 AS Numeric(18, 0)), CAST(3040000 AS Numeric(18, 0)), 0)
INSERT [dbo].[DonNhap] ([MaDN], [TenNCC], [SoLuong], [TenThuoc], [GiaNhap], [TongTien], [DaXoa]) VALUES (10, N'Cong ty duoc Trung ương 5', 700, N'Thuốc cảm Pharbaco', CAST(8900 AS Numeric(18, 0)), CAST(6230000 AS Numeric(18, 0)), 0)
SET IDENTITY_INSERT [dbo].[DonNhap] OFF
SET IDENTITY_INSERT [dbo].[DonThuoc] ON 

INSERT [dbo].[DonThuoc] ([MaDon], [NgayLap], [MaNV], [DaXoa], [MaKH], [MaChiNhanh]) VALUES (1, CAST(N'2023-09-28 00:00:00.000' AS DateTime), 4, 0, 1, 1)
INSERT [dbo].[DonThuoc] ([MaDon], [NgayLap], [MaNV], [DaXoa], [MaKH], [MaChiNhanh]) VALUES (2, CAST(N'2023-10-17 00:00:00.000' AS DateTime), 2, 0, 2, 2)
INSERT [dbo].[DonThuoc] ([MaDon], [NgayLap], [MaNV], [DaXoa], [MaKH], [MaChiNhanh]) VALUES (3, CAST(N'2023-08-14 00:00:00.000' AS DateTime), 3, 0, 3, 3)
INSERT [dbo].[DonThuoc] ([MaDon], [NgayLap], [MaNV], [DaXoa], [MaKH], [MaChiNhanh]) VALUES (4, CAST(N'2023-09-12 00:00:00.000' AS DateTime), 1, 0, 4, 1)
INSERT [dbo].[DonThuoc] ([MaDon], [NgayLap], [MaNV], [DaXoa], [MaKH], [MaChiNhanh]) VALUES (5, CAST(N'2023-08-12 00:00:00.000' AS DateTime), 4, 0, 3, 3)
INSERT [dbo].[DonThuoc] ([MaDon], [NgayLap], [MaNV], [DaXoa], [MaKH], [MaChiNhanh]) VALUES (8, CAST(N'2022-01-01 00:00:00.000' AS DateTime), 1, 0, 1, 1)
SET IDENTITY_INSERT [dbo].[DonThuoc] OFF
SET IDENTITY_INSERT [dbo].[KhachHang] ON 

INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChi], [SDT], [DaXoa]) VALUES (1, N'Pham Thi Thai My', N'Cao Lanh', N'0328297517', 0)
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChi], [SDT], [DaXoa]) VALUES (2, N'Nguyen Thi Minh Khoa M', N'Thap Muoi', N'0328297618', 0)
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChi], [SDT], [DaXoa]) VALUES (3, N'Dinh Nhut Hao', N'Cao Lanh', N'0314524521', 0)
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChi], [SDT], [DaXoa]) VALUES (4, N'Le Hai Nam', N'Lai Vung', N'0523623423', 0)
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChi], [SDT], [DaXoa]) VALUES (5, N'Phan Huu Trung Nguyen', N'TP Cao Lanh', N'0423425455', 0)
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChi], [SDT], [DaXoa]) VALUES (6, N'Nguyen Van A', N'An Giang', N'0243561344', 0)
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChi], [SDT], [DaXoa]) VALUES (7, N'Le Van B', N'Tien Giang', N'0232514325', 0)
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChi], [SDT], [DaXoa]) VALUES (8, N'Nguyen Thi C', N'HCM', N'0321456343', 0)
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChi], [SDT], [DaXoa]) VALUES (9, N'Ho Van C', N'Hau Giang', N'0423531323', 0)
SET IDENTITY_INSERT [dbo].[KhachHang] OFF
SET IDENTITY_INSERT [dbo].[LoaiThuoc] ON 

INSERT [dbo].[LoaiThuoc] ([MaLoai], [TenLoai], [DaXoa]) VALUES (1, N'Thuoc Cam', 0)
INSERT [dbo].[LoaiThuoc] ([MaLoai], [TenLoai], [DaXoa]) VALUES (2, N'Khang Sinh', 0)
INSERT [dbo].[LoaiThuoc] ([MaLoai], [TenLoai], [DaXoa]) VALUES (3, N'Ha Sot', 0)
INSERT [dbo].[LoaiThuoc] ([MaLoai], [TenLoai], [DaXoa]) VALUES (4, N'Huyet Ap', 0)
INSERT [dbo].[LoaiThuoc] ([MaLoai], [TenLoai], [DaXoa]) VALUES (5, N'Tieu Duong', 0)
INSERT [dbo].[LoaiThuoc] ([MaLoai], [TenLoai], [DaXoa]) VALUES (6, N'Tim Mach', 0)
INSERT [dbo].[LoaiThuoc] ([MaLoai], [TenLoai], [DaXoa]) VALUES (7, N'Da Day', 0)
INSERT [dbo].[LoaiThuoc] ([MaLoai], [TenLoai], [DaXoa]) VALUES (8, N'Xuong Khop', 0)
INSERT [dbo].[LoaiThuoc] ([MaLoai], [TenLoai], [DaXoa]) VALUES (9, N'Thuoc Ho', 0)
INSERT [dbo].[LoaiThuoc] ([MaLoai], [TenLoai], [DaXoa]) VALUES (10, N'Nhut Dau', 0)
INSERT [dbo].[LoaiThuoc] ([MaLoai], [TenLoai], [DaXoa]) VALUES (11, N'Dau Mat', 1)
INSERT [dbo].[LoaiThuoc] ([MaLoai], [TenLoai], [DaXoa]) VALUES (14, N'Dau Bung', 1)
INSERT [dbo].[LoaiThuoc] ([MaLoai], [TenLoai], [DaXoa]) VALUES (15, N'Dau Dau', 1)
SET IDENTITY_INSERT [dbo].[LoaiThuoc] OFF
INSERT [dbo].[Login] ([TaiKhoan], [MatKhau], [MaNhanVien], [DaXoa]) VALUES (N'-1', N'123456', 8, 0)
INSERT [dbo].[Login] ([TaiKhoan], [MatKhau], [MaNhanVien], [DaXoa]) VALUES (N'hainam', N'admin123', 1, 0)
INSERT [dbo].[Login] ([TaiKhoan], [MatKhau], [MaNhanVien], [DaXoa]) VALUES (N'hainam10989', N'123456', 1, 0)
INSERT [dbo].[Login] ([TaiKhoan], [MatKhau], [MaNhanVien], [DaXoa]) VALUES (N'minhkhoa', N'khoa123', 4, 0)
INSERT [dbo].[Login] ([TaiKhoan], [MatKhau], [MaNhanVien], [DaXoa]) VALUES (N'nhuthao', N'hao123', 2, 0)
INSERT [dbo].[Login] ([TaiKhoan], [MatKhau], [MaNhanVien], [DaXoa]) VALUES (N'thaimy', N'my123', 3, 0)
INSERT [dbo].[Login] ([TaiKhoan], [MatKhau], [MaNhanVien], [DaXoa]) VALUES (N'trungnguyen', N'nguyen123', 5, 0)
INSERT [dbo].[Login] ([TaiKhoan], [MatKhau], [MaNhanVien], [DaXoa]) VALUES (N'vana', N'vana123', 6, 0)
SET IDENTITY_INSERT [dbo].[NhaCungCap] ON 

INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [DiaChi], [SDT], [DaXoa]) VALUES (1, N'Cong ty duoc Hau Giang', N'Hau Giang', N'0328297517', 0)
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [DiaChi], [SDT], [DaXoa]) VALUES (2, N'Cong ty duoc Traphaco', N'DongThap', N'1231241434', 0)
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [DiaChi], [SDT], [DaXoa]) VALUES (3, N'Cong ty duoc Pymepharco', N'HCM', N'1563446363', 0)
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [DiaChi], [SDT], [DaXoa]) VALUES (4, N'Cong ty duoc ImexPharm', N'HCM', N'4653632344', 0)
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [DiaChi], [SDT], [DaXoa]) VALUES (5, N'Cong ty duoc DOMESCO', N'Tien Giang', N'1241231443', 0)
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [DiaChi], [SDT], [DaXoa]) VALUES (6, N'Cong ty duoc Dược phẩm 3/2', N'An Giang', N'1241241344', 0)
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [DiaChi], [SDT], [DaXoa]) VALUES (7, N'Cong ty duoc Trung ương 1', N'HCM', N'2341241443', 0)
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [DiaChi], [SDT], [DaXoa]) VALUES (8, N'Cong ty duoc Trung ương 2', N'HCM', N'1242332542', NULL)
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [DiaChi], [SDT], [DaXoa]) VALUES (9, N'Cong ty duoc Trung ương 3', N'HCM', N'1231232131', NULL)
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [DiaChi], [SDT], [DaXoa]) VALUES (10, N'Cong ty duoc Trung ương 5', N'HCM', N'1232141445', 0)
SET IDENTITY_INSERT [dbo].[NhaCungCap] OFF
SET IDENTITY_INSERT [dbo].[NhanVien] ON 

INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [ChucVu], [NgaySinh], [DaXoa]) VALUES (1, N'Le Hai Nam', N'Duoc Si', CAST(N'2001-04-11 00:00:00.000' AS DateTime), 0)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [ChucVu], [NgaySinh], [DaXoa]) VALUES (2, N'Dinh Nhut Hao', N'Quan Ly', CAST(N'2002-05-22 00:00:00.000' AS DateTime), 0)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [ChucVu], [NgaySinh], [DaXoa]) VALUES (3, N'Thai My', N'Duoc Si', CAST(N'2002-09-21 00:00:00.000' AS DateTime), 0)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [ChucVu], [NgaySinh], [DaXoa]) VALUES (4, N'Minh Khoa', N'Duoc Si', CAST(N'2022-07-20 00:00:00.000' AS DateTime), 0)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [ChucVu], [NgaySinh], [DaXoa]) VALUES (5, N'Trung Nguyen', N'Duoc Si', CAST(N'2022-09-22 00:00:00.000' AS DateTime), 0)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [ChucVu], [NgaySinh], [DaXoa]) VALUES (6, N'Nguyen Van A', N'Duoc Si', CAST(N'2001-08-22 00:00:00.000' AS DateTime), 1)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [ChucVu], [NgaySinh], [DaXoa]) VALUES (7, N'hao', N'Quản Lý', CAST(N'2002-05-14 00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [ChucVu], [NgaySinh], [DaXoa]) VALUES (8, N'hao', N'Duoc Si', CAST(N'2002-05-14 00:00:00.000' AS DateTime), NULL)
SET IDENTITY_INSERT [dbo].[NhanVien] OFF
SET IDENTITY_INSERT [dbo].[Thuoc] ON 

INSERT [dbo].[Thuoc] ([MaThuoc], [TenThuoc], [MaLoai], [SoLuong], [GiaBan], [DVT], [DaXoa], [MaNCC], [MaDN]) VALUES (19, N'Thuốc Efferalgan', 1, 1, CAST(230000 AS Numeric(18, 0)), N'Goi', 0, 5, 1)
INSERT [dbo].[Thuoc] ([MaThuoc], [TenThuoc], [MaLoai], [SoLuong], [GiaBan], [DVT], [DaXoa], [MaNCC], [MaDN]) VALUES (20, N'Curcumin fast', 7, 10, CAST(2000 AS Numeric(18, 0)), N'Bit', 0, 2, 2)
INSERT [dbo].[Thuoc] ([MaThuoc], [TenThuoc], [MaLoai], [SoLuong], [GiaBan], [DVT], [DaXoa], [MaNCC], [MaDN]) VALUES (21, N'Acetaminophen 500 mg', 3, 100, CAST(24000 AS Numeric(18, 0)), N'Hop', 0, 3, 3)
INSERT [dbo].[Thuoc] ([MaThuoc], [TenThuoc], [MaLoai], [SoLuong], [GiaBan], [DVT], [DaXoa], [MaNCC], [MaDN]) VALUES (22, N'Gentamicin sulfate 80 mg', 2, 200, CAST(8000 AS Numeric(18, 0)), N'Hop', 0, 4, 4)
INSERT [dbo].[Thuoc] ([MaThuoc], [TenThuoc], [MaLoai], [SoLuong], [GiaBan], [DVT], [DaXoa], [MaNCC], [MaDN]) VALUES (23, N'Omeprazol DOMESCO', 7, 50, CAST(8500 AS Numeric(18, 0)), N'Hop', 0, 5, 5)
INSERT [dbo].[Thuoc] ([MaThuoc], [TenThuoc], [MaLoai], [SoLuong], [GiaBan], [DVT], [DaXoa], [MaNCC], [MaDN]) VALUES (24, N'Rosuvastatin', 3, 100, CAST(10000 AS Numeric(18, 0)), N'Hop', 0, 6, 6)
INSERT [dbo].[Thuoc] ([MaThuoc], [TenThuoc], [MaLoai], [SoLuong], [GiaBan], [DVT], [DaXoa], [MaNCC], [MaDN]) VALUES (25, N'Digoxin Pharbaco', 4, 75, CAST(10000 AS Numeric(18, 0)), N'Goi', 0, 7, 7)
INSERT [dbo].[Thuoc] ([MaThuoc], [TenThuoc], [MaLoai], [SoLuong], [GiaBan], [DVT], [DaXoa], [MaNCC], [MaDN]) VALUES (26, N'Glucosamine sulfate Pharbaco', 8, 87, CAST(5000 AS Numeric(18, 0)), N'Hop', 0, 8, 8)
INSERT [dbo].[Thuoc] ([MaThuoc], [TenThuoc], [MaLoai], [SoLuong], [GiaBan], [DVT], [DaXoa], [MaNCC], [MaDN]) VALUES (27, N'Thuốc ho Pharbaco', 9, 67, CAST(9000 AS Numeric(18, 0)), N'Goi', 0, 9, 9)
INSERT [dbo].[Thuoc] ([MaThuoc], [TenThuoc], [MaLoai], [SoLuong], [GiaBan], [DVT], [DaXoa], [MaNCC], [MaDN]) VALUES (28, N'Thuốc cảm Pharbaco', 1, NULL, CAST(10000 AS Numeric(18, 0)), N'Goi', 0, 10, 10)
INSERT [dbo].[Thuoc] ([MaThuoc], [TenThuoc], [MaLoai], [SoLuong], [GiaBan], [DVT], [DaXoa], [MaNCC], [MaDN]) VALUES (33, N'Thuốc Efferalgan', 1, 1, CAST(230000 AS Numeric(18, 0)), N'Goi', 0, 1, NULL)
INSERT [dbo].[Thuoc] ([MaThuoc], [TenThuoc], [MaLoai], [SoLuong], [GiaBan], [DVT], [DaXoa], [MaNCC], [MaDN]) VALUES (35, N'cam', 1, 40, CAST(200000 AS Numeric(18, 0)), N'bit', 0, 1, NULL)
SET IDENTITY_INSERT [dbo].[Thuoc] OFF
ALTER TABLE [dbo].[ChiTietDon]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietDon_DonThuoc] FOREIGN KEY([MaDon])
REFERENCES [dbo].[DonThuoc] ([MaDon])
GO
ALTER TABLE [dbo].[ChiTietDon] CHECK CONSTRAINT [FK_ChiTietDon_DonThuoc]
GO
ALTER TABLE [dbo].[ChiTietDon]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietDon_Thuoc] FOREIGN KEY([MaThuoc])
REFERENCES [dbo].[Thuoc] ([MaThuoc])
GO
ALTER TABLE [dbo].[ChiTietDon] CHECK CONSTRAINT [FK_ChiTietDon_Thuoc]
GO
ALTER TABLE [dbo].[DonThuoc]  WITH CHECK ADD  CONSTRAINT [FK_DonThuoc_ChiNhanh] FOREIGN KEY([MaChiNhanh])
REFERENCES [dbo].[ChiNhanh] ([MaChiNhanh])
GO
ALTER TABLE [dbo].[DonThuoc] CHECK CONSTRAINT [FK_DonThuoc_ChiNhanh]
GO
ALTER TABLE [dbo].[DonThuoc]  WITH CHECK ADD  CONSTRAINT [FK_DonThuoc_KhachHang] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[DonThuoc] CHECK CONSTRAINT [FK_DonThuoc_KhachHang]
GO
ALTER TABLE [dbo].[DonThuoc]  WITH CHECK ADD  CONSTRAINT [FK_DonThuoc_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[DonThuoc] CHECK CONSTRAINT [FK_DonThuoc_NhanVien]
GO
ALTER TABLE [dbo].[Login]  WITH CHECK ADD  CONSTRAINT [FK_Login_NhanVien] FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[Login] CHECK CONSTRAINT [FK_Login_NhanVien]
GO
ALTER TABLE [dbo].[Thuoc]  WITH CHECK ADD  CONSTRAINT [FK_Thuoc_DonNhap] FOREIGN KEY([MaDN])
REFERENCES [dbo].[DonNhap] ([MaDN])
GO
ALTER TABLE [dbo].[Thuoc] CHECK CONSTRAINT [FK_Thuoc_DonNhap]
GO
ALTER TABLE [dbo].[Thuoc]  WITH CHECK ADD  CONSTRAINT [FK_Thuoc_LoaiThuoc] FOREIGN KEY([MaLoai])
REFERENCES [dbo].[LoaiThuoc] ([MaLoai])
GO
ALTER TABLE [dbo].[Thuoc] CHECK CONSTRAINT [FK_Thuoc_LoaiThuoc]
GO
ALTER TABLE [dbo].[Thuoc]  WITH CHECK ADD  CONSTRAINT [FK_Thuoc_NhaCungCap] FOREIGN KEY([MaNCC])
REFERENCES [dbo].[NhaCungCap] ([MaNCC])
GO
ALTER TABLE [dbo].[Thuoc] CHECK CONSTRAINT [FK_Thuoc_NhaCungCap]
GO
