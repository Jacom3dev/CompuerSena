using ComputerSena.Models.Entidades;
using ComputerSena.Servicios.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComputerSena.WEB.Controllers
{
    public class EntradasController : Controller
    {
        private readonly IEntradaServicios _EntradaServicios;
        public EntradasController(IEntradaServicios entradaServicios)
        {
            _EntradaServicios = entradaServicios;
        }
        public async Task< IActionResult> Entradas()
        {
            return View(await _EntradaServicios.ListarEntrada());
        }

        [HttpGet]
        public async Task<IActionResult> CrearEntrada()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CrearEntrada(EntradaSalida entrada)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _EntradaServicios.CrearEntrada(entrada);
                    var guardar = await _EntradaServicios.GuardarCambios();
                    if (guardar)
                    {
                        return Json(new { isValid = true, operacion = "crear" });
                    }
                }
                catch (Exception)
                {
                    return Json(new { isValid = false, tipoError = "error", error = "Error al crear el registro" });

                }
            }
            return Json(new { isValid = false, tipoError = "warning", error = "Rellene todos los campos correctamente. " });
        }
    }
}
