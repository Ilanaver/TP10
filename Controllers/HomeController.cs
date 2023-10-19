using Microsoft.AspNetCore.Mvc;

namespace TP10.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        ViewBag.mostraSerie = BD.MostrarSeries();
        return View();
    }

    [HttpPost]
    public List<Actores> infoActores(int serie){
        ViewBag.obtenAct = BD.ObtenerActores(serie);
        return ViewBag.obtenAct;
    }
    public Series infoSerie(int serie){
        ViewBag.obtenserie = BD.ObtenerSerie(serie);
        return ViewBag.obtenserie;
    }
    public List<Temporadas> infoTemporadas(int IdSerie){
        ViewBag.temporada = BD.ObtenerTemporadas(IdSerie);
        return ViewBag.temporada;
    }
}
