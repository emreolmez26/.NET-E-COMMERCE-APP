using Microsoft.EntityFrameworkCore;
namespace dotnet_entity.Models;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options) // Constructor, base sınıfın constructor'ını çağırır
    {

    }
    public DbSet<Urun> Urunler { get; set; } // Tablo adı Urunler olacak
    public DbSet<Kategori> Kategoriler { get; set; } // Tablo adı Kategoriler olacak
    public DbSet<Slider> Sliderlar { get; set; } // Tablo adı Sliderlar olacak

    protected override void OnModelCreating(ModelBuilder modelBuilder) // Veritabanı oluşturulurken çalışır
    {
        base.OnModelCreating(modelBuilder); // Base sınıfın OnModelCreating metodunu çağırır

        modelBuilder.Entity<Slider>().HasData( // Veritabanı oluşturulurken başlangıç verisi ekler.
            new List<Slider>
            {
                new Slider { Id = 1, Resim = "slider-1.jpeg", Baslik = "İndirimli Ürünler", Aciklama = "İndirimli Ürünler", Aktif = true, Index = 0 },
                new Slider { Id = 2, Resim = "slider-2.jpeg", Baslik = "Yeni Gelen Ürünler", Aciklama = "Yeni Gelen Ürünler" , Aktif = true, Index = 1 },
                new Slider { Id = 3, Resim = "slider-3.jpeg", Baslik = "Popüler Ürünler", Aciklama = "Popüler Ürünler", Aktif = true, Index = 2 }
            }
        );
        
        modelBuilder.Entity<Kategori>().HasData( // Veritabanı oluşturulurken başlangıç verisi ekler.
            new List<Kategori>
            {
                new Kategori { Id = 1, KategoriAdi = "Akıllı Saat", Url = "akilli-saat" },
                new Kategori { Id = 2, KategoriAdi = "Telefon", Url = "telefon" },
                new Kategori { Id = 3, KategoriAdi = "Tablet", Url = "tablet" },
                new Kategori { Id = 4, KategoriAdi = "Laptop", Url = "laptop" },
                new Kategori { Id = 5, KategoriAdi = "Kulaklık", Url = "kulaklik" }
            }
        );

        modelBuilder.Entity<Urun>().HasData( // Veritabanı oluşturulurken başlangıç verisi ekler.
            new List<Urun>
            {
                new Urun { Id = 1, Ad = "Apple Watch", Fiyat = 40000, Aktif = true,Resim="1.jpeg",Aciklama="Apple Watch Serisi 7" ,Anasayfa=true, KategoriId = 1 },
                new Urun { Id = 2, Ad = "Apple Telefon", Fiyat = 30000, Aktif = true,Resim="2.jpeg",Aciklama="Apple iPhone 13 Pro Max",Anasayfa=true , KategoriId = 2 },
                new Urun { Id = 3, Ad = "Apple Kalem", Fiyat = 20000, Aktif = true,Resim="3.jpeg",Aciklama="Apple Pencil 2.Nesil",Anasayfa=false , KategoriId = 5 },
                new Urun { Id = 4, Ad = "Apple Tablet", Fiyat = 25000, Aktif = true,Resim="4.jpeg",Aciklama="Apple iPad Pro 2021",Anasayfa=true , KategoriId = 3 },
                new Urun { Id = 5, Ad = "Apple Laptop", Fiyat = 50000, Aktif = true,Resim="5.jpeg",Aciklama="Apple MacBook Pro M1",Anasayfa=false , KategoriId = 4 },
                new Urun { Id = 6, Ad = "Apple Kulaklık", Fiyat = 15000, Aktif = true,Resim="6.jpeg",Aciklama="Apple AirPods Pro",Anasayfa=false , KategoriId = 5 }
                
            }
        );
    }
}

// DataContext _context = new DataContext();