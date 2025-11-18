using Microsoft.AspNetCore.Mvc;
namespace dotnet_entity.Controllers;


public class UrunController : Controller
{
    private readonly Models.DataContext _context; // DbContext'i kullanmak için
    public UrunController(Models.DataContext context) // Dependency Injection ile DataContext alıyoruz
    {
        _context = context;
    }

    public ActionResult Index()
    {
        return View();
    }
    public ActionResult List()
    {
        var urunler = _context.Urunler.Where(u => u.Aktif).ToList(); // Veritabanından tüm aktif ürünleri alıyoruz
        return View(urunler); // Ürünleri View'a gönderiyoruz. 
    }
    public ActionResult Details(int id) // id parametresi ile ürünün detaylarını alıyoruz
    {
        var urun = _context.Urunler.FirstOrDefault(u => u.Id == id); // Veritabanından id'ye göre ürünü alıyoruz
        if (urun == null)
        {
            return NotFound(); // Ürün bulunamazsa 404 döndürüyoruz
        }
        return View(urun); // Ürünü View'a gönderiyoruz
    }
}
