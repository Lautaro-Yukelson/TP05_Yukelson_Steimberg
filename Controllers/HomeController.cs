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

    [HttpPost]
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

    [HttpPost]
    public IActionResult GuardarResultado(string nombre, TimeSpan tiempo, int errores){
        Escape.AgregarJugador(new Jugador(nombre, tiempo, errores));
        return RedirectToAction("Ranking", "Home");
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
