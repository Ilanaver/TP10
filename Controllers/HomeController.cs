using Microsoft.AspNetCore.Mvc;

namespace TP10.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        BD.MostrarSeries();
        return View();
    }
    public IActionResult infoActores(int serie){
        BD.ObtenerActores(serie);
        return
    }
}
