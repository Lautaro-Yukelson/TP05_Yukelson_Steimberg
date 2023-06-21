using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP05_Yukelson_Steimberg.Models;

namespace TP05_Yukelson_Steimberg.Controllers;

public class SalasController : Controller
{
    public IActionResult Sala1(){
        int temp = Escape.GetEstadoJuego();
        ViewBag.sala = temp;
        return View("Sala" + temp);
    }
    public IActionResult Sala2(){
        int temp = Escape.GetEstadoJuego();
        ViewBag.sala = temp;
        return View("Sala" + temp);
    }
    public IActionResult Sala3(){
        int temp = Escape.GetEstadoJuego();
        ViewBag.sala = temp;
        return View("Sala" + temp);
    }
    public IActionResult Sala4(){
        int temp = Escape.GetEstadoJuego();
        ViewBag.sala = temp;
        return View("Sala" + temp);
    }
    public IActionResult Sala5(){
        int temp = Escape.GetEstadoJuego();
        ViewBag.sala = temp;
        return View("Sala" + temp);
    }
    public IActionResult Sala6(){
        int temp = Escape.GetEstadoJuego();
        ViewBag.sala = temp;
        return View("Sala" + temp);
    }
    public IActionResult Sala7(){
        int temp = Escape.GetEstadoJuego();
        ViewBag.sala = temp;
        return View("Sala" + temp);
    }
    public IActionResult Sala8(){
        int temp = Escape.GetEstadoJuego();
        ViewBag.sala = temp;
        return View("Sala" + temp);
    }
    public IActionResult Sala9(){
        int temp = Escape.GetEstadoJuego();
        ViewBag.sala = temp;
        return View("Sala" + temp);
    }

}
