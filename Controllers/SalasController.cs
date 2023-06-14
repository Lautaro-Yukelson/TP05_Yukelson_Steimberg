using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP05_Yukelson_Steimberg.Models;

namespace TP05_Yukelson_Steimberg.Controllers;

public class SalasController : Controller
{
    public IActionResult Sala1(){
        ViewBag.sala = Escape.GetEstadoJuego();
        return View();
    }
    public IActionResult Sala2(){
        ViewBag.sala = Escape.GetEstadoJuego();
        return View();
    }
    public IActionResult Sala3(){
        ViewBag.sala = Escape.GetEstadoJuego();
        return View();
    }
    public IActionResult Sala4(){
        ViewBag.sala = Escape.GetEstadoJuego();
        return View();
    }
    public IActionResult Sala5(){
        ViewBag.sala = Escape.GetEstadoJuego();
        return View();
    }
    public IActionResult Sala6(){
        ViewBag.sala = Escape.GetEstadoJuego();
        return View();
    }
    public IActionResult Sala7(){
        ViewBag.sala = Escape.GetEstadoJuego();
        return View();
    }
    public IActionResult Sala8(){
        ViewBag.sala = Escape.GetEstadoJuego();
        return View();
    }
    public IActionResult Sala9(){
        ViewBag.sala = Escape.GetEstadoJuego();
        return View();
    }

}
