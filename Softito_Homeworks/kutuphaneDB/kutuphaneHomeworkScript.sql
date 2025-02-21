USE [master]
GO
/****** Object:  Database [Kutuphane]    Script Date: 11.02.2025 22:51:29 ******/
CREATE DATABASE [Kutuphane]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Kutuphane', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\Kutuphane.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Kutuphane_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\Kutuphane_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [Kutuphane] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Kutuphane].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Kutuphane] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Kutuphane] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Kutuphane] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Kutuphane] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Kutuphane] SET ARITHABORT OFF 
GO
ALTER DATABASE [Kutuphane] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Kutuphane] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Kutuphane] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Kutuphane] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Kutuphane] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Kutuphane] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Kutuphane] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Kutuphane] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Kutuphane] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Kutuphane] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Kutuphane] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Kutuphane] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Kutuphane] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Kutuphane] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Kutuphane] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Kutuphane] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Kutuphane] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Kutuphane] SET RECOVERY FULL 
GO
ALTER DATABASE [Kutuphane] SET  MULTI_USER 
GO
ALTER DATABASE [Kutuphane] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Kutuphane] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Kutuphane] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Kutuphane] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Kutuphane] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Kutuphane] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Kutuphane', N'ON'
GO
ALTER DATABASE [Kutuphane] SET QUERY_STORE = ON
GO
ALTER DATABASE [Kutuphane] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [Kutuphane]
GO
/****** Object:  Table [dbo].[Yazar]    Script Date: 11.02.2025 22:51:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Yazar](
	[Id] [int] NOT NULL,
	[ad] [varchar](35) NOT NULL,
	[soyad] [varchar](35) NOT NULL,
	[dogum_yili] [int] NULL,
	[uyruk] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kitap]    Script Date: 11.02.2025 22:51:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kitap](
	[Id] [int] NOT NULL,
	[isim] [varchar](35) NOT NULL,
	[yazarId] [int] NULL,
	[yil] [int] NULL,
	[kategoriId] [int] NULL,
	[stok] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[yazarkitapgorunumu]    Script Date: 11.02.2025 22:51:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[yazarkitapgorunumu] as
select y.Id,y.ad,y.soyad, count (k.Id) as kitapsayisi
from Kitap k right join Yazar y on y.Id=k.yazarId
group by y.Id,y.ad,y.soyad
GO
/****** Object:  Table [dbo].[Odunc_kitap]    Script Date: 11.02.2025 22:51:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Odunc_kitap](
	[UyeId] [int] NOT NULL,
	[KitapId] [int] NOT NULL,
	[alisDate] [date] NULL,
	[iadeDate] [date] NULL
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[hicalinmamiskitaplar]    Script Date: 11.02.2025 22:51:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[hicalinmamiskitaplar] as 
select k.Id,k.isim,k.stok
from Kitap k left join Odunc_kitap ok on k.Id=ok.KitapId
where ok.KitapId is null
GO
/****** Object:  Table [dbo].[Kategori]    Script Date: 11.02.2025 22:51:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kategori](
	[Id] [int] NOT NULL,
	[tur] [varchar](35) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[kategoriyegorekitapsayisi]    Script Date: 11.02.2025 22:51:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[kategoriyegorekitapsayisi] as
select ka.tur, count(k.Id) as kitapsayisi
from Kategori ka left join Kitap k on k.kategoriId=ka.Id
group by ka.tur
GO
/****** Object:  Table [dbo].[Personel]    Script Date: 11.02.2025 22:51:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Personel](
	[Id] [int] NOT NULL,
	[isim] [varchar](35) NOT NULL,
	[gorev] [varchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Uye]    Script Date: 11.02.2025 22:51:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Uye](
	[Id] [int] NOT NULL,
	[ad] [varchar](35) NOT NULL,
	[soyad] [varchar](35) NOT NULL,
	[dogum_yili] [int] NULL,
	[telefon] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Kategori] ([Id], [tur]) VALUES (1, N'roman')
INSERT [dbo].[Kategori] ([Id], [tur]) VALUES (2, N'polisiye')
INSERT [dbo].[Kategori] ([Id], [tur]) VALUES (3, N'korku')
INSERT [dbo].[Kategori] ([Id], [tur]) VALUES (4, N'hikaye')
INSERT [dbo].[Kategori] ([Id], [tur]) VALUES (5, N'fantastik')
INSERT [dbo].[Kategori] ([Id], [tur]) VALUES (6, N'psikoloji')
INSERT [dbo].[Kategori] ([Id], [tur]) VALUES (7, N'felsefe')
INSERT [dbo].[Kategori] ([Id], [tur]) VALUES (8, N'siir')
GO
INSERT [dbo].[Kitap] ([Id], [isim], [yazarId], [yil], [kategoriId], [stok]) VALUES (1, N'suc ve ceza', 1, 1866, 1, 1)
INSERT [dbo].[Kitap] ([Id], [isim], [yazarId], [yil], [kategoriId], [stok]) VALUES (2, N'yabanci', 2, 1942, 1, 5)
INSERT [dbo].[Kitap] ([Id], [isim], [yazarId], [yil], [kategoriId], [stok]) VALUES (3, N'donusum', 3, 1915, 1, 2)
INSERT [dbo].[Kitap] ([Id], [isim], [yazarId], [yil], [kategoriId], [stok]) VALUES (4, N'ucurtma avcisi', 4, 2003, 1, 1)
INSERT [dbo].[Kitap] ([Id], [isim], [yazarId], [yil], [kategoriId], [stok]) VALUES (5, N'kayip zamanin izinde', 5, 1913, 1, 0)
INSERT [dbo].[Kitap] ([Id], [isim], [yazarId], [yil], [kategoriId], [stok]) VALUES (6, N'korku uykusu', 11, 1982, 3, 1)
INSERT [dbo].[Kitap] ([Id], [isim], [yazarId], [yil], [kategoriId], [stok]) VALUES (7, N'1984', 13, 1949, 1, 1)
INSERT [dbo].[Kitap] ([Id], [isim], [yazarId], [yil], [kategoriId], [stok]) VALUES (8, N'dort mevsim', 7, 1954, 4, 1)
INSERT [dbo].[Kitap] ([Id], [isim], [yazarId], [yil], [kategoriId], [stok]) VALUES (9, N'yuzyillik yalnizlik', 15, 1967, 1, 1)
INSERT [dbo].[Kitap] ([Id], [isim], [yazarId], [yil], [kategoriId], [stok]) VALUES (10, N'buyulu dag', 14, 1927, 1, 1)
INSERT [dbo].[Kitap] ([Id], [isim], [yazarId], [yil], [kategoriId], [stok]) VALUES (11, N'kayip sehir', 18, 1937, 5, 1)
INSERT [dbo].[Kitap] ([Id], [isim], [yazarId], [yil], [kategoriId], [stok]) VALUES (12, N'siirler', 6, 1943, 8, 1)
INSERT [dbo].[Kitap] ([Id], [isim], [yazarId], [yil], [kategoriId], [stok]) VALUES (13, N'otuz bes yas', 16, 1946, 8, 1)
INSERT [dbo].[Kitap] ([Id], [isim], [yazarId], [yil], [kategoriId], [stok]) VALUES (14, N'milenaya mektuplar', 3, 1954, 1, 2)
INSERT [dbo].[Kitap] ([Id], [isim], [yazarId], [yil], [kategoriId], [stok]) VALUES (15, N'hayvan ciftligi', 13, 1945, 1, 1)
INSERT [dbo].[Kitap] ([Id], [isim], [yazarId], [yil], [kategoriId], [stok]) VALUES (16, N'aylak adam', 15, 1926, 1, 1)
INSERT [dbo].[Kitap] ([Id], [isim], [yazarId], [yil], [kategoriId], [stok]) VALUES (17, N'tutunamayanlar', 8, 1971, 1, 3)
INSERT [dbo].[Kitap] ([Id], [isim], [yazarId], [yil], [kategoriId], [stok]) VALUES (18, N'cennet cayirlarinda', 9, 1932, 1, 1)
INSERT [dbo].[Kitap] ([Id], [isim], [yazarId], [yil], [kategoriId], [stok]) VALUES (19, N'bulbulu oldurmek', 10, 19601, 1, 2)
INSERT [dbo].[Kitap] ([Id], [isim], [yazarId], [yil], [kategoriId], [stok]) VALUES (20, N'harry potter', 19, 1997, 5, 3)
INSERT [dbo].[Kitap] ([Id], [isim], [yazarId], [yil], [kategoriId], [stok]) VALUES (21, N'calgin', 17, 1994, 6, 1)
INSERT [dbo].[Kitap] ([Id], [isim], [yazarId], [yil], [kategoriId], [stok]) VALUES (22, N'simyaci', 17, 1988, 1, 1)
INSERT [dbo].[Kitap] ([Id], [isim], [yazarId], [yil], [kategoriId], [stok]) VALUES (23, N'savas ve baris', 7, 1869, 1, 1)
INSERT [dbo].[Kitap] ([Id], [isim], [yazarId], [yil], [kategoriId], [stok]) VALUES (24, N'seytanin avukati', 12, 1990, 1, 1)
GO
INSERT [dbo].[Odunc_kitap] ([UyeId], [KitapId], [alisDate], [iadeDate]) VALUES (1, 2, CAST(N'2025-01-15' AS Date), CAST(N'2025-02-11' AS Date))
INSERT [dbo].[Odunc_kitap] ([UyeId], [KitapId], [alisDate], [iadeDate]) VALUES (3, 1, CAST(N'2025-01-20' AS Date), CAST(N'2025-02-10' AS Date))
INSERT [dbo].[Odunc_kitap] ([UyeId], [KitapId], [alisDate], [iadeDate]) VALUES (2, 15, CAST(N'2025-01-25' AS Date), CAST(N'2025-02-15' AS Date))
INSERT [dbo].[Odunc_kitap] ([UyeId], [KitapId], [alisDate], [iadeDate]) VALUES (4, 6, CAST(N'2025-01-30' AS Date), CAST(N'2025-02-20' AS Date))
INSERT [dbo].[Odunc_kitap] ([UyeId], [KitapId], [alisDate], [iadeDate]) VALUES (10, 10, CAST(N'2025-02-06' AS Date), CAST(N'2025-02-27' AS Date))
INSERT [dbo].[Odunc_kitap] ([UyeId], [KitapId], [alisDate], [iadeDate]) VALUES (6, 12, CAST(N'2025-02-01' AS Date), CAST(N'2025-02-28' AS Date))
INSERT [dbo].[Odunc_kitap] ([UyeId], [KitapId], [alisDate], [iadeDate]) VALUES (8, 19, CAST(N'2025-02-14' AS Date), CAST(N'2025-03-06' AS Date))
INSERT [dbo].[Odunc_kitap] ([UyeId], [KitapId], [alisDate], [iadeDate]) VALUES (5, 14, CAST(N'2025-02-10' AS Date), CAST(N'2025-03-02' AS Date))
INSERT [dbo].[Odunc_kitap] ([UyeId], [KitapId], [alisDate], [iadeDate]) VALUES (7, 17, CAST(N'2024-02-10' AS Date), CAST(N'2024-03-02' AS Date))
INSERT [dbo].[Odunc_kitap] ([UyeId], [KitapId], [alisDate], [iadeDate]) VALUES (9, 17, CAST(N'2025-03-01' AS Date), CAST(N'2025-03-16' AS Date))
INSERT [dbo].[Odunc_kitap] ([UyeId], [KitapId], [alisDate], [iadeDate]) VALUES (9, 18, CAST(N'2024-03-01' AS Date), CAST(N'2025-03-27' AS Date))
GO
INSERT [dbo].[Personel] ([Id], [isim], [gorev]) VALUES (1, N'osman', N'kutuphaneci')
INSERT [dbo].[Personel] ([Id], [isim], [gorev]) VALUES (2, N'mert', N'danisma gorevlisi')
INSERT [dbo].[Personel] ([Id], [isim], [gorev]) VALUES (3, N'veli', N'kutuphaneci')
INSERT [dbo].[Personel] ([Id], [isim], [gorev]) VALUES (4, N'firuze', N'kutuphane muduru')
INSERT [dbo].[Personel] ([Id], [isim], [gorev]) VALUES (5, N'hasan', N'arsiv sorumlusu')
INSERT [dbo].[Personel] ([Id], [isim], [gorev]) VALUES (6, N'hayriye', N'bilgi islem')
INSERT [dbo].[Personel] ([Id], [isim], [gorev]) VALUES (7, N'gul', N'temizlik personeli')
INSERT [dbo].[Personel] ([Id], [isim], [gorev]) VALUES (8, N'huseyin', N'temizlik gorevlisi')
GO
INSERT [dbo].[Uye] ([Id], [ad], [soyad], [dogum_yili], [telefon]) VALUES (1, N'ahmet', N'yilmaz', 1995, N'5512367892')
INSERT [dbo].[Uye] ([Id], [ad], [soyad], [dogum_yili], [telefon]) VALUES (2, N'elif', N'demir', 2000, N'5324690023')
INSERT [dbo].[Uye] ([Id], [ad], [soyad], [dogum_yili], [telefon]) VALUES (3, N'mehmet', N'celik', 1998, N'5369874521')
INSERT [dbo].[Uye] ([Id], [ad], [soyad], [dogum_yili], [telefon]) VALUES (4, N'ayse', N'karaca', 1997, N'5469872356')
INSERT [dbo].[Uye] ([Id], [ad], [soyad], [dogum_yili], [telefon]) VALUES (5, N'burak', N'korkmaz', 2002, N'5894672356')
INSERT [dbo].[Uye] ([Id], [ad], [soyad], [dogum_yili], [telefon]) VALUES (6, N'selin', N'kilic', 2001, N'5465697821')
INSERT [dbo].[Uye] ([Id], [ad], [soyad], [dogum_yili], [telefon]) VALUES (7, N'emre', N'ozdemir', 2001, N'5497896321')
INSERT [dbo].[Uye] ([Id], [ad], [soyad], [dogum_yili], [telefon]) VALUES (8, N'onur', N'sahin', 2002, N'5399637865')
INSERT [dbo].[Uye] ([Id], [ad], [soyad], [dogum_yili], [telefon]) VALUES (9, N'buse', N'yildiz', 2003, N'5699637896')
INSERT [dbo].[Uye] ([Id], [ad], [soyad], [dogum_yili], [telefon]) VALUES (10, N'zeynep', N'aydin', 2002, N'5626233663')
INSERT [dbo].[Uye] ([Id], [ad], [soyad], [dogum_yili], [telefon]) VALUES (12, N'gizem', N'a', 2001, N'5625629696')
GO
INSERT [dbo].[Yazar] ([Id], [ad], [soyad], [dogum_yili], [uyruk]) VALUES (1, N'fyodor', N'dostoyevski', 1821, N'rusya')
INSERT [dbo].[Yazar] ([Id], [ad], [soyad], [dogum_yili], [uyruk]) VALUES (2, N'albert', N'camus', 1913, N'fransa')
INSERT [dbo].[Yazar] ([Id], [ad], [soyad], [dogum_yili], [uyruk]) VALUES (3, N'franz', N'kafka', 1883, N'cekya')
INSERT [dbo].[Yazar] ([Id], [ad], [soyad], [dogum_yili], [uyruk]) VALUES (4, N'agatha', N'christie', 1890, N'uk')
INSERT [dbo].[Yazar] ([Id], [ad], [soyad], [dogum_yili], [uyruk]) VALUES (5, N'yasar', N'kemal', 1923, N'turkiye')
INSERT [dbo].[Yazar] ([Id], [ad], [soyad], [dogum_yili], [uyruk]) VALUES (6, N'nazim', N'hikmet', 1902, N'turkiye')
INSERT [dbo].[Yazar] ([Id], [ad], [soyad], [dogum_yili], [uyruk]) VALUES (7, N'resat nuri', N'guntekin', 1889, N'turkiye')
INSERT [dbo].[Yazar] ([Id], [ad], [soyad], [dogum_yili], [uyruk]) VALUES (8, N'oguz', N'atay', 1934, N'turkiye')
INSERT [dbo].[Yazar] ([Id], [ad], [soyad], [dogum_yili], [uyruk]) VALUES (9, N'john', N'steinback', 1902, N'abd')
INSERT [dbo].[Yazar] ([Id], [ad], [soyad], [dogum_yili], [uyruk]) VALUES (10, N'harper', N'lee', 1926, N'abd')
INSERT [dbo].[Yazar] ([Id], [ad], [soyad], [dogum_yili], [uyruk]) VALUES (11, N'stephen', N'king', 1926, N'abd')
INSERT [dbo].[Yazar] ([Id], [ad], [soyad], [dogum_yili], [uyruk]) VALUES (12, N'victor', N'higo', 1802, N'fransa')
INSERT [dbo].[Yazar] ([Id], [ad], [soyad], [dogum_yili], [uyruk]) VALUES (13, N'george', N'orwell', 1903, N'uk')
INSERT [dbo].[Yazar] ([Id], [ad], [soyad], [dogum_yili], [uyruk]) VALUES (14, N'stefan', N'zweig', 1881, N'avusturya')
INSERT [dbo].[Yazar] ([Id], [ad], [soyad], [dogum_yili], [uyruk]) VALUES (15, N'sabahttin', N'ali', 1907, N'turkiye')
INSERT [dbo].[Yazar] ([Id], [ad], [soyad], [dogum_yili], [uyruk]) VALUES (16, N'cahit sıtkı', N'tarancı', 1910, N'turkiye')
INSERT [dbo].[Yazar] ([Id], [ad], [soyad], [dogum_yili], [uyruk]) VALUES (17, N'paulo', N'coelho', 1947, N'brezilya')
INSERT [dbo].[Yazar] ([Id], [ad], [soyad], [dogum_yili], [uyruk]) VALUES (18, N'j.r.r', N'tolkien', 1892, N'uk')
INSERT [dbo].[Yazar] ([Id], [ad], [soyad], [dogum_yili], [uyruk]) VALUES (19, N'j.k', N'rowling', 1965, N'uk')
GO
ALTER TABLE [dbo].[Kitap]  WITH CHECK ADD FOREIGN KEY([kategoriId])
REFERENCES [dbo].[Kategori] ([Id])
GO
ALTER TABLE [dbo].[Kitap]  WITH CHECK ADD FOREIGN KEY([yazarId])
REFERENCES [dbo].[Yazar] ([Id])
GO
ALTER TABLE [dbo].[Odunc_kitap]  WITH CHECK ADD FOREIGN KEY([KitapId])
REFERENCES [dbo].[Kitap] ([Id])
GO
ALTER TABLE [dbo].[Odunc_kitap]  WITH CHECK ADD FOREIGN KEY([UyeId])
REFERENCES [dbo].[Uye] ([Id])
GO
/****** Object:  StoredProcedure [dbo].[uyedekikitap]    Script Date: 11.02.2025 22:51:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[uyedekikitap]
(
   @uyeId int
)
as
begin
select LEFT(u.ad,2)+'.'+u.soyad as AdSoyad, k.isim, ok.alisDate
from Odunc_kitap ok 
inner join Uye u  on ok.UyeId=u.Id
inner join Kitap k  on k.Id=ok.KitapId
where u.Id= @uyeId;
end
GO
/****** Object:  StoredProcedure [dbo].[yeniuyeekle]    Script Date: 11.02.2025 22:51:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[yeniuyeekle]
(
    @Id int,
    @ad NVARCHAR(35),
    @soyad NVARCHAR(35),
    @dogum_yili int,
    @telefon VARCHAR(10)
)
as
begin 
insert Uye (Id,ad,soyad,dogum_yili,telefon)
values (@Id,@ad, @soyad, @dogum_yili, @telefon)
end
GO
USE [master]
GO
ALTER DATABASE [Kutuphane] SET  READ_WRITE 
GO
