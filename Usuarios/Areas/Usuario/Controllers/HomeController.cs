using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Usuarios.Areas.Usuario.Controllers
{
    [Area("Usuario")]
    public class UsuarioController : Controller
    {
        public IActionResult Usuario()
        {
            return View();
        }
    }
}
