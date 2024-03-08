using Microsoft.AspNetCore.Mvc;

namespace practica1;

public class HomeController : Controller{
    private readonly IDataContext _context;

    public HomeController(IDataContext context){
        _context = context;
    }

    public async Task<IActionResult> Index(){
        List<Producto> productos = await _context.ObtenerProductosAsync();
        return View(productos);
    }

    public IActionResult Error(){
        return View();
    }
}