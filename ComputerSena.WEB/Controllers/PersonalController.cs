using ComputerSena.Servicios.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComputerSena.WEB.Controllers
{
    public class PersonalController : Controller
    {
        private readonly IPersonalServicios _personaServicios;
        public PersonalController(IPersonalServicios personaServicios)
        {
            _personaServicios = personaServicios;
        }
        public async Task< IActionResult> Personal()
        {
            return View(await _personaServicios.ListarPersonal());
        }
    }
}
