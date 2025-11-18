# .NET E-Commerce Application

ASP.NET Core MVC ve Entity Framework Core kullanılarak geliştirilmiş bir e-ticaret uygulaması.

## 🚀 Özellikler

- **Ürün Yönetimi**: Ürün listeleme, detay görüntüleme
- **Kategori Sistemi**: Kategoriye göre ürün filtreleme
- **Entity Framework Core**: Code-First yaklaşımı ile veritabanı yönetimi
- **SQLite Veritabanı**: Hafif ve taşınabilir veritabanı
- **Responsive Tasarım**: Bootstrap ile mobil uyumlu arayüz

## 📋 Teknolojiler

- **.NET 9.0**
- **ASP.NET Core MVC**
- **Entity Framework Core 9.0**
- **SQLite**
- **Bootstrap 5**
- **jQuery**

## 🛠️ Kurulum

### Gereksinimler

- [.NET 9.0 SDK](https://dotnet.microsoft.com/download)
- Bir kod editörü (Visual Studio, VS Code, vb.)

### Adımlar

1. Projeyi klonlayın:
```bash
git clone https://github.com/emreolmez26/.NET-E-COMMERCE-APP.git
cd .NET-E-COMMERCE-APP
```

2. Bağımlılıkları yükleyin:
```bash
dotnet restore
```

3. Veritabanını oluşturun:
```bash
dotnet ef database update
```

4. Uygulamayı çalıştırın:
```bash
dotnet run
```

5. Tarayıcınızda açın: `https://localhost:5001` veya `http://localhost:5000`

## 📦 Veritabanı Yapısı

### Urun (Ürün)
- `Id`: Primary Key
- `Ad`: Ürün adı
- `Fiyat`: Ürün fiyatı
- `Resim`: Ürün resmi
- `Aciklama`: Ürün açıklaması
- `Aktif`: Ürün aktif mi?
- `Anasayfa`: Anasayfada göster
- `KategoriId`: Foreign Key (Kategori)

### Kategori
- `Id`: Primary Key
- `KategoriAdi`: Kategori adı
- `Url`: Kategori URL'i
- `Uruns`: Navigation Property (Ürün listesi)

## 🗂️ Proje Yapısı

```
dotnet-entity/
├── Controllers/         # MVC Controllers
├── Models/             # Entity modelleri ve DbContext
├── Views/              # Razor view dosyaları
│   ├── Home/
│   ├── Urun/
│   └── Shared/
├── wwwroot/            # Statik dosyalar (CSS, JS, resimler)
├── Migrations/         # EF Core migrations
└── Program.cs          # Uygulama başlangıç noktası
```

## 📝 Migration Komutları

Yeni migration oluşturma:
```bash
dotnet ef migrations add MigrationAdi
```

Veritabanını güncelleme:
```bash
dotnet ef database update
```

## 🤝 Katkıda Bulunma

1. Bu projeyi fork edin
2. Feature branch oluşturun (`git checkout -b feature/AmazingFeature`)
3. Değişikliklerinizi commit edin (`git commit -m 'Add some AmazingFeature'`)
4. Branch'inizi push edin (`git push origin feature/AmazingFeature`)
5. Pull Request oluşturun

## 📄 Lisans

Bu proje MIT lisansı altında lisanslanmıştır.

## 👤 Geliştirici

**Emre Ölmez**
- GitHub: [@emreolmez26](https://github.com/emreolmez26)
