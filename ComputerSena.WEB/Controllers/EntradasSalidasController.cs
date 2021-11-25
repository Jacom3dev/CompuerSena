using ComputerSena.Models.Entidades;
using ComputerSena.Servicios.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComputerSena.WEB.Controllers
{
    public class EntradasSalidasController : Controller
    {
        private readonly IEntradaSalidaServicios _entradasSalidas;

        public EntradasSalidasController(IEntradaSalidaServicios entradasSalidas)
        {
            _entradasSalidas = entradasSalidas;
        }
        public async Task<IActionResult> EntradasSalidas()
        {
            return View(await _entradasSalidas.ListarEntradaSalidas());
        }
        [HttpGet]
        public async Task<IActionResult> ActualizarEntradaSalida (int ID)
        {
            if (ID != 0)
            {
                try
                {
                    var EntradaSalida = await  _entradasSalidas.GetEntradaSalida(ID);
                    if (EntradaSalida != null)
                    {
                        @ViewData["Title"] = "Actulizar registro";

                        return View(EntradaSalida);
                    }
                    else
                        return Json(new { isValid = false, tipoError = "error", mensaje = "No existe el registro" });
                }
                catch (Exception)
                {
                    return Json(new { isValid = false, tipoError = "error", mensaje = "Error interno" });
                }

            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> ActualizarEntradaSalida(int ID, EntradaSalida entradaSalida)
        {
            if (ID != entradaSalida.EntradaSalidaID)
                return Json(new { isValid = false, tipoError = "error", mensaje = "Error interno" });
            if (ModelState.IsValid)
            {
                try
                {
                    _entradasSalidas.ActualizarEntradaSalida(entradaSalida);
                    var editar = await _entradasSalidas.GuardarCambios();
                    if (editar)
                        return Json(new { isValid = true, operacion = "editar" });
                    else
                        return Json(new { isValid = false, tipoError = "error", mensaje = "Error interno" });
                }
                catch (Exception)
                {

                    return Json(new { isValid = false, tipoError = "error", mensaje = "Error interno" });
                }
            }
            // si el modelo tiene errores en las validaciones
            ViewBag.Titulo = "Editar cliente";
            return Json(new { isValid = false, tipoError = "warning", error = "Debe diligenciar los campos requeridos" });
        }
        public async Task<IActionResult> CambiarEstado(int ID)
        {
            if (ID != 0)
            {
                try
                {
                    var entradaSalida = await _entradasSalidas.GetEntradaSalida(ID);
                    if (entradaSalida != null)
                    {
                        entradaSalida.Estado = !entradaSalida.Estado;
                        entradaSalida.FechaSalida = DateTime.Now;

                        _entradasSalidas.ActualizarEntradaSalida(entradaSalida);

                        var guardar = await _entradasSalidas.GuardarCambios();
                        if (guardar)
                            return Json(new { isValid = true });

                    }
                    return Json(new { isValid = false, tipoError = "error", mensaje = "Error interno" });

                }
                catch (Exception)
                {

                    return Json(new { isValid = false, tipoError = "error", mensaje = "Error interno" });
                }

            }
            return Json(new { isValid = false, tipoError = "error", mensaje = "Error interno" });
        }


    }
}
