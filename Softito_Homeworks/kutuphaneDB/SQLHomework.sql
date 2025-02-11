--1-1 idli uyenin odunc aldigi kitap
--select* 
--from Uye u inner join Odunc_kitap  ok on u.Id=ok.UyeId 
--where u.Id=1

--2-tum kitaplar 
--select* from Kitap

--3- en cok odunc alinan kitabi bul
--select k.isim, count(ok.KitapId) as oduncalmasayisi
--from Odunc_kitap ok inner join Kitap k on k.Id=ok.KitapId
--group by k.isim
--order by oduncalmasayisi desc

--4-bir uyenin odunc aldigi kitaplar id 9 
--select u.ad, u.soyad,ok.KitapId,k.isim 
--from Odunc_kitap ok inner join Kitap k on k.Id=ok.KitapId
--inner join Uye u on ok.UyeId=u.ad
--where  u.Id=9;

--5- turu roman olan kitaplar
--select k.isim
--from Kitap k inner join Kategori ka on ka.Id=k.kategoriId
--where ka.tur='roman'

--6-son 30 gun icinde odunc alinan kitaplar
--select * from Odunc_kitap
--where alisDate>= DATEADD(DAY,-30, GETDATE())

--7- iade suresi gecen kitaplar 
--select* from Odunc_kitap ok inner join Uye u on u.Id=ok.UyeId
--inner join Kitap k on k.Id=ok.KitapId
--where ok.iadeDate< GETDATE()

--8- franz kafkanin kitaplari
--select k.isim from Kitap k inner join Yazar y on y.Id=k.yazarId
--where y.ad='franz'

--9- left kullanma
--select LEFT(u.ad,1)+'.'+u.soyad as isimsoyisim 
--from uye u 

--10- yazarlarin sistmede kac kitabi var 
--select left(y.ad,3)+'.'+y.soyad as 'yazaradsoyad', count (k.Id) as 'kitapsayisi'
--from Yazar y left join Kitap k on k.yazarId= y.Id
--group by left(y.ad,3)+'.'+y.soyad
--order by kitapsayisi desc

--11- 70 yasindan buyuk ingiliz olmayan yazarlar
--select*
--from Yazar y
--where (YEAR(getdate())- y.dogum_yili)>70 and y.uyruk <> 'uk'

--12- isminin icinde a gecen uyeler
--select * from Uye u
--where u.ad like'%a%'

--13- having kullanma - 1 den fazla kitabi olan yazarlar
--select y.Id,y.ad,y.soyad, count (k.Id) as kitapsayisi
--from Kitap k inner join Yazar y on y.Id=k.yazarId
--group by y.Id,y.ad,y.soyad
--having count (k.Id)>1
--order by  y.ad desc

--view 

--create view yazarkitapgorunumu as
--select y.Id,y.ad,y.soyad, count (k.Id) as kitapsayisi
--from Kitap k right join Yazar y on y.Id=k.yazarId
--group by y.Id,y.ad,y.soyad

--select * from yazarkitapgorunumu order by kitapsayisi desc

--create view hicalinmamiskitaplar as 
--select k.Id,k.isim,k.stok
--from Kitap k left join Odunc_kitap ok on k.Id=ok.KitapId
--where ok.KitapId is null

--select* from hicalinmamiskitaplar h order by h.isim desc

--create view kategoriyegorekitapsayisi as
--select ka.tur, count(k.Id) as kitapsayisi
--from Kategori ka left join Kitap k on k.kategoriId=ka.Id
--group by ka.tur

--select * from kategoriyegorekitapsayisi

-- update delete insert foksiyonlari 
--update Kitap
--set stok=4
--where isim ='yabanci'

--delete from personel
--where isim='huseyin'

--insert Personel(Id,isim,gorev)
--values (8,'huseyin','temizlik gorevlisi')



-- stored procedures

--yeni uye eklemesi
--create proc yeniuyeekle
--(
--    @Id int,
--    @ad NVARCHAR(35),
--    @soyad NVARCHAR(35),
--    @dogum_yili int,
--    @telefon VARCHAR(10)
--)
--as
--begin 
--insert Uye (Id,ad,soyad,dogum_yili,telefon)
--values (@Id,@ad, @soyad, @dogum_yili, @telefon)
--end

--exec yeniuyeekle 12,'gizem','a',2001,'5625629696'

--uyeye verilmis olan kitaplar procedur
--create proc uyedekikitap
--(
--   @uyeId int
--)
--as
--begin
--select LEFT(u.ad,2)+'.'+u.soyad as AdSoyad, k.isim, ok.alisDate
--from Odunc_kitap ok 
--inner join Uye u  on ok.UyeId=u.Id
--inner join Kitap k  on k.Id=ok.KitapId
--where u.Id= @uyeId;
--end

--exec uyedekikitap @uyeId=9;



--trigger
create trigger kitapiadeet
on Odunc_kitap after update as begin
declare @kitapId int
select @kitapId = KitapId from inserted
    IF @kitapId IS NOT NULL
    BEGIN
        UPDATE Kitap
        SET Stok = Stok + 1
        WHERE Id = @kitapId
    END;
END;

DROP TRIGGER kitapiade; --yanlis trigger uretildi ve silindi

update Odunc_kitap set iadeDate = '2025-02-11' where UyeId=1 and KitapId=2

select* from Kitap
select* from Odunc_kitap

DROP TRIGGER kitapoduncal;

create trigger kitapoduncal 
on Odunc_kitap after update
as 
begin
  IF update(alisDate)
  begin
  Update Kitap set Stok = Stok -1  
  from Kitap k inner join inserted i
  on k.Id = i.KitapId

  Update Odunc_kitap set iadeDate = DATEADD(week, 3, Getdate())
  from Odunc_kitap ok inner join inserted i
  on ok.KitapId = i.KitapId 
  end
end;


update Odunc_kitap set alisDate = GETDATE() 
where UyeId= 5 and KitapId= 2


create trigger kitapstok
on Kitap
after update
as 
begin
if exists (select 1 from inserted where stok < 0)
 begin
    throw 50000, 'stok miktarý negatif olamaz!', 1;
    rollback transaction;
  end
end

UPDATE Kitap
SET stok = -5
WHERE Id = 21 ;
select* from Kitap
