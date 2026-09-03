# GaziKültür - Kurulum Talimatları

## 1. Zip'i aç
Bu zip'i masaüstünde veya `Belgelerim/Visual Studio 2022/Projects/` gibi bir yere çıkar (extract et).
İçinden çıkan klasör adı `GaziKultur` olacak, içinde 5 proje ve `GaziKultur.sln` dosyası var.

## 2. Solution'ı aç
`GaziKultur.sln` dosyasına çift tıkla, Visual Studio ile açılacak.

## 3. NuGet paketlerini geri yükle
Visual Studio açıldığında sağ üstte "Paketler geri yükleniyor" gibi bir bildirim görebilirsin,
yoksa: Solution'a sağ tık → **NuGet Paketlerini Geri Yükle (Restore NuGet Packages)**

Ayrıca üstteki menüden: **Araçlar → NuGet Paket Yöneticisi → Paket Yöneticisi Konsolu** açıp
şunu yaz ve Enter'a bas:
```
Update-Package -reinstall
```
(İnternet bağlantın varsa genelde otomatik iner, bu adıma gerek kalmaz.)

## 4. Başlangıç projesini kontrol et
Solution Explorer'da **GaziKultur.WebAPI** projesinin adı **kalın (bold)** yazıyor olmalı
(bu, "hangi proje çalıştırılacak" demek). Değilse: GaziKultur.WebAPI'ye sağ tık →
**Başlangıç Projesi Olarak Ayarla**

## 5. Veritabanı bağlantısını kendine göre düzenle
`GaziKultur.Data/Concrete/EntityFramework/GaziKulturContext.cs` dosyasını aç,
içindeki bağlantı cümlesini (connection string) kendi SQL Server ayarına göre değiştir:
```csharp
optionsBuilder.UseSqlServer("Server=.;Database=GaziKulturDb;Trusted_Connection=True;TrustServerCertificate=True;");
```
`Server=.` genelde yerel SQL Server'ı işaret eder, bilgisayarındaki SQL Server adıyla aynıysa
dokunmana gerek yok.

## 6. İlk migration'ı oluştur
**Araçlar → NuGet Paket Yöneticisi → Paket Yöneticisi Konsolu**'nu aç, üstteki
"Varsayılan proje (Default project)" kutusundan **GaziKultur.Data**'yı seç, sonra:
```
Add-Migration IlkMigration -StartupProject GaziKultur.WebAPI
Update-Database -StartupProject GaziKultur.WebAPI
```
Bu, `Kutuphaneler` ve `Muzeler` tablolarını veritabanında oluşturur.

## 7. Çalıştır
Üstteki yeşil ok (▶) butonuna bas (GaziKultur.WebAPI seçili olsun). Tarayıcıda Swagger sayfası
açılacak, orada `/api/Kutuphane` ve `/api/Muze` endpoint'lerini test edebilirsin.

## Katman yapısı
- **GaziKultur.Core** → Generic repository sözleşmesi (IEntity, IEntityRepository<T>), hiçbir yere bağımlı değil
- **GaziKultur.Entity** → Kutuphane, Muze sınıfları (Guid ID ile)
- **GaziKultur.Data** → EF Core, DbContext, generic repository implementasyonu
- **GaziKultur.Service** → İş kuralları (KutuphaneManager, MuzeManager)
- **GaziKultur.WebAPI** → Controller'lar, Swagger, CORS ayarı (frontend'in bağlanabilmesi için)

Bir sonraki adım: frontend'deki (HTML/CSS/JS) iki sayfayı (Kütüphaneler, Müzeler) bu API'ye
bağlamak olacak.
