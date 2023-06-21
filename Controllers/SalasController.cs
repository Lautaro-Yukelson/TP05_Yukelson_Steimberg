using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP05_Yukelson_Steimberg.Models;

namespace TP05_Yukelson_Steimberg.Controllers;

public class SalasController : Controller
{
    public IActionResult Sala(){
        ViewBag.sala = Escape.GetEstadoJuego();
        if (ViewBag.sala != 10){
            return View("Sala" + ViewBag.sala);
        } else {
            return RedirectToAction("Creditos", "Home");
        }
    }
}