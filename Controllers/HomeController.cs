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
        ViewBag.sesion = Escape.GetSesion();
        return View();
    }

    public IActionResult Tutorial(){
        return View();
    }

    public IActionResult Comenzar(){
        ViewBag.sala = Escape.GetEstadoJuego();
        Escape.ResetearJuego();
        Escape.SetPrimeraVez(true);
        return View();
    }

    public IActionResult Continuar(){
        Escape.SetPrimeraVez(true);
        return View();
    }

    [HttpPost]
    public IActionResult Habitacion(int sala, string clave){
        Escape.SetResuelto(Escape.ResolverSala(sala, clave));
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
        ViewBag.sesion = Escape.GetSesion();
        return View();
    }

    [HttpPost]
    public IActionResult EliminarJugador(int idE){
        BD.EliminarJugador(idE);
        return RedirectToAction("Ranking", "Home");
    }

    [HttpPost]
    public IActionResult VolverAEmpezar(){
        Escape.ResetearJuego();
        return RedirectToAction("Comenzar", "Home");
    }

    public IActionResult Login(){
        int sesion = Escape.GetSesion();
        ViewBag.sesion = sesion;
        if (sesion == 0 || sesion == 1){
            return View();
        } else if (sesion == 2 || sesion == 3){
            return RedirectToAction("Index", "Home");
        }
        return View();
    }

    public IActionResult Logout(){
        Escape.SetSesion(-1);
        return RedirectToAction("Index", "Home");
    }

    public IActionResult CheckLogin(string usuario, string contrasena){
        Escape.SetSesion(Escape.CheckUsuario(usuario, contrasena));
        return RedirectToAction("Login", "Home");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error(){
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
