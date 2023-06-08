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

}
