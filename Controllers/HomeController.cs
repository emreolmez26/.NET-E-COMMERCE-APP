using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using dotnet_entity.Models;

namespace dotnet_entity.Controllers;

public class HomeController : Controller
{
    private readonly DataContext _context;

    public HomeController(DataContext context)
    {
        _context = context;
    }

    public ActionResult Index()
    {
        var urunler = _context.Urunler.Where(u => u.Anasayfa && u.Aktif).ToList();
        ViewData["Kategoriler"] = _context.Kategoriler.ToList();
        return View(urunler);
    }
}
