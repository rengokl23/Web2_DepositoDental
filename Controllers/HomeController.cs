using Microsoft.AspNetCore.Mvc;
using DepositoDental.Data;

public class HomeController : Controller
{
    private readonly ApplicationDbContext _context;

    public HomeController(ApplicationDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        ViewBag.TotalClientes = _context.Clientes.Count();
        ViewBag.TotalProveedores = _context.Proveedores.Count();
        ViewBag.TotalProductos = _context.Productos.Count();
        ViewBag.TotalVentas = _context.Ventas.Count();

        return View();
    }
}
