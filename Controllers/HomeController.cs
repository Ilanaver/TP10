using Microsoft.AspNetCore.Mvc;

namespace TP10.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        ViewBag.mostraSerie = BD.MostrarSeries();
        return View();
    }
    public List<Actores> infoActores(int serie){
        ViewBag.obtenAct = BD.ObtenerActores(serie);
        return ViewBag.obtenAct;
    }
    public List<Series> infoSerie(int serie){
        ViewBag.obtenserie = BD.ObtenerSeries(serie);
        return ViewBag.obtenserie;
    }
    public List<Temporadas> infoTemporadas(int serie){
        ViewBag.temporada = BD.ObtenerTemporadas(serie);
        return ViewBag.temporada;
    }
}
