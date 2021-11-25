using ComputerSena.Servicios.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComputerSena.WEB.Controllers
{
    public class SalidasController : Controller
    {
        private readonly ISalidaServicios _salidaServicios;
        public SalidasController(ISalidaServicios salidaServicios)
        {
            _salidaServicios = salidaServicios;
        }

        public async Task<IActionResult> Salidas()
        {
            return View(await _salidaServicios.ListarSalidas());
        }
    }
}
