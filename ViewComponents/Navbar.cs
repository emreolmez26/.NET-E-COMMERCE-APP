using dotnet_entity.Models;
using Microsoft.AspNetCore.Mvc;
namespace dotnet_entity.ViewComponents;

public class Navbar : ViewComponent
{
    private readonly DataContext _context;

    public Navbar(DataContext context)
    {
        _context = context;
    }

    public IViewComponentResult Invoke()
    {
        var kategoriler = _context.Kategoriler.ToList();
        return View(kategoriler);
    }
}