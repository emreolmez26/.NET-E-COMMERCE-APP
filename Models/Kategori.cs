namespace dotnet_entity.Models;

public class Kategori
{
    public int Id { get; set; }
    public string? KategoriAdi { get; set; }
    public string? Url { get; set; }
    public List<Urun> Uruns { get; set; } = new(); // Neden List<Urun> olarak tanımlandı? Çünkü bir kategorinin birden fazla ürünü olabilir.
}