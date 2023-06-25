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
        Escape.ResetearJuego();
        Escape.primeraVez = true;
        return View();
    }

    public IActionResult Continuar(){
        Escape.primeraVez = true;
        return View();
    }

    [HttpPost]
    public IActionResult Habitacion(int sala, string clave){
        Escape.resuelto = Escape.ResolverSala(sala, clave);
        ViewBag.siguienteSala = Escape.GetEstadoJuego();
        return RedirectToAction("Sala", "Salas");
    }

    public IActionResult Creditos(){
        if (Escape.GetEstadoJuego() != 10){
            return RedirectToAction("Continuar", "Home");
        }
        else{
            ViewBag.tiempoTranscurrido = Escape.TerminarJuego();
            ViewBag.errores = Escape.GetErrores();
            return View();
        }
    }

    [HttpPost]
    public IActionResult GuardarResultado(string nombre, TimeSpan tiempo, int errores){
        BD.AgregarJugador(new Jugador(nombre, errores, tiempo));
        return RedirectToAction("Ranking", "Home");
    }

    public IActionResult Ranking(){
        BD.LevantarJugadores();
        ViewBag.Jugadores = BD.GetListadoJugadores();
        return View();
    }

    [HttpPost]
    public IActionResult VolverAEmpezar(){
        Escape.ResetearJuego();
        return RedirectToAction("Comenzar", "Home");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error(){
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
