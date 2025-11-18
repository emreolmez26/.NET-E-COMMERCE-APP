namespace dotnet_entity.Models;


public class Urun
{
    public int Id { get; set; }
    public string? Ad { get; set; }
    public decimal Fiyat { get; set; }
    public string? Resim { get; set; }
    public string? Aciklama { get; set; }
    public bool Aktif { get; set; }
    public bool Anasayfa { get; set; }  
    public int KategoriId { get; set; } // Foreign key
    public Kategori Kategori { get; set; } = null!;  // Navigation property
}