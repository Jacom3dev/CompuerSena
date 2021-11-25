using ComputerSena.Models.Entidades;
using ComputerSena.Servicios.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComputerSena.WEB.Controllers
{
    public class RolesController : Controller
    {
        private readonly IRolServicios _rolServicios;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<Usuario> _userManager;

        public RolesController(IRolServicios rolServicios, RoleManager<IdentityRole> roleManager, UserManager<Usuario> userManager)
        {
            _rolServicios = rolServicios;
            _roleManager = roleManager;
            _userManager = userManager;
        }

        public async Task< IActionResult> Roles()
        {
            return View(await _rolServicios.ListarRoles());
        }
        [HttpGet]
        public async Task<IActionResult> EditarRol(int ID)
        {
            if (ID != 0)
            {
                try
                {
                    var rol = await _rolServicios.GetRoles(ID);
                    if (rol != null)
                    {
                        @ViewData["Title"] = "Editar Rol";

                        return View(rol);
                    }
                    else
                        return Json(new { isValid = false, tipoError = "error", mensaje = "No existe el rol" });
                }
                catch (Exception)
                {
                    return Json(new { isValid = false, tipoError = "error", mensaje = "Error interno" });
                }

            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> EditarRol(int ID, Rol rol)
        {

            if (ID != rol.RolID)
                return Json(new { isValid = false, tipoError = "error", mensaje = "Error interno" });
            if (ModelState.IsValid)
            {
                try
                {
                    _rolServicios.EditarRoles(rol);
                    var editar = await _rolServicios.GuardarCambios();
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
            ViewBag.Titulo = "Editar Rol";
            return Json(new { isValid = false, tipoError = "warning", error = "Debe diligenciar los campos requeridos" });
        }
        public async Task<IActionResult> CambiarEstado(int ID)
        {
            if (ID != 0)
            {
                try
                {
                    var rol = await _rolServicios.GetRoles(ID);
                    if (rol != null)
                    {
                        rol.Estado = !rol.Estado;

                        _rolServicios.EditarRoles(rol);

                        var guardar = await _rolServicios.GuardarCambios();
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
