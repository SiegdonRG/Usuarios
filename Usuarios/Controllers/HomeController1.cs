using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Usuarios.Controllers
{
    //[Route("[controller]")]
    public class UsuariosController : Controller
    {
        //[HttpGet]
        //[Route("/Usuarios/Brandowo")]
        //[HttpGet("[controller]/[action]/{data:double}")]
        public IActionResult Index(double data)
        {
            //var url = Url.Action("Metodo","Usuarios", new { age = 23, name = "Yisus owo" });
            //return View("Index", data);
            var url = Url.RouteUrl("Brandoncito", new { age = 23, name = "Brandoncito" });
            return Redirect(url);
        }
        [HttpGet("[controller]/[action]",Name = "Brandoncito")]
        public IActionResult Metodo(int code)
        {
            var data = $"Codigo de estado {code}";
            return View("Index", data);
        }
    }
}
