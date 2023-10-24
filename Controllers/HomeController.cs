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
    public List<Actores> infoActores(int IdSerie){
        ViewBag.obtenAct = BD.ObtenerActores(IdSerie);
        return ViewBag.obtenAct;
    }
    public Series infoSerie(int IdSerie){
        ViewBag.obtenserie = BD.ObtenerSerie(IdSerie);
        return ViewBag.obtenserie;
    }
    public List<Temporadas> infoTemporadas(int IdSerie){
        ViewBag.temporada = BD.ObtenerTemporadas(IdSerie);
        return ViewBag.temporada;
    }
}
