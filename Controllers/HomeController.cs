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
        return BD.ObtenerActores(serie);
    }
    public IActionResult infoSerie(int serie){
        return BD.ObtenerSeries(serie);
    }
    public IActionResult infoTemporadas(int serie){
        return BD.ObtenerTemporadas(serie);
    }
}
