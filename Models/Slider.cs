namespace dotnet_entity.Models;

public class Slider
{
    public int Id { get; set; }
    public string? Resim { get; set; }
    public string? Baslik { get; set; }
    public string? Aciklama { get; set; }
    public bool Aktif { get; set; }
    public int Index { get; set; }
}