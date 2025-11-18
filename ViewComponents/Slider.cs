namespace dotnet_entity.ViewComponents;

using Microsoft.AspNetCore.Mvc;
using dotnet_entity.Models;

public class Slider : ViewComponent
{
    private readonly DataContext _context;

    public Slider(DataContext context)
    {
        _context = context;
    }

    public IViewComponentResult Invoke()
    {
        var sliderlar = _context.Sliderlar.Where(s => s.Aktif).OrderBy(s => s.Index).ToList();
        return View(sliderlar);
    }
}