using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP05_Yukelson_Steimberg.Models;

namespace TP05_Yukelson_Steimberg.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger){
        _logger = logger;
    }

    public IActionResult Index(){
        return View();
    }

    public IActionResult Tutorial(){
        return View();
    }

    public IActionResult Comenzar(){
        ViewBag.sala = Escape.GetEstadoJuego();
        return View();
    }

    public IActionResult Habitacion(int sala, string clave)
    {
        ViewBag.resuelto = Escape.ResolverSala(sala, clave);
        ViewBag.siguienteSala = Escape.GetEstadoJuego();
        return RedirectToAction("Sala", "Salas");
    }

    public IActionResult Creditos(){
        if (Escape.GetEstadoJuego() != 10){
            return RedirectToAction("Sala", "Salas");
        }
        else{
            ViewBag.tiempoTranscurrido = Escape.TerminarJuego();
            ViewBag.errores = Escape.GetErrores();
            return View();
        }
    }

    public IActionResult Ranking(){
        Escape.OrdenarJugadores();
        ViewBag.Jugadores = Escape.GetJugadores();
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error(){
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
