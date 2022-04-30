using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PostAzureAD.Controllers {
    public class UsuariosController : Controller {
        [Authorize]
        public IActionResult Cuenta() {
            return View();
        }
    }
}
