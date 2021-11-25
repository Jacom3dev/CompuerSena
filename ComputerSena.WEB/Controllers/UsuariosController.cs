using ComputerSena.Models.Entidades;
using ComputerSena.Servicios.DTOS;
using ComputerSena.Servicios.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;

namespace ComputerSena.WEB.Controllers
{
    public class UsuariosController : Controller
    {
        private readonly SignInManager<Usuario> _signInManager;
        private readonly IUsuarioServicios _usuarioServicios;
        private readonly UserManager<Usuario> _userManager;

        public UsuariosController(IUsuarioServicios usuarioServicios, SignInManager<Usuario> signInManager, UserManager<Usuario> userManager)
        {
            _signInManager = signInManager;
            _usuarioServicios = usuarioServicios;
            _userManager = userManager;
        }

        public async Task<IActionResult> Usuarios()
        {

            return View(await _usuarioServicios.ListarUsuarios());
        }

        [HttpGet]
        public async Task<IActionResult> CrearUsuario()
        {
            ViewBag.tiposDocumentos = new SelectList(await _usuarioServicios.TiposDocumento(), "TipoDocumentoID", "Nombre");
            ViewBag.roles = new SelectList(await _usuarioServicios.Roles(), "RolID", "Nombre");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CrearUsuario(RegistrarUsuarioDto registrarUsuarioDto)
        {

            if (ModelState.IsValid)
            {    //search email of user (comprovar si existe)
                var email = await _usuarioServicios.GetUserDtoforEmail(registrarUsuarioDto.Email);
                if (email == null)
                {
                    try
                    {
                        var usuario = await _usuarioServicios.Create(registrarUsuarioDto);
                        if (usuario == null)
                            return Json(new { isValid = false, tipoError = "error", error = "Error al crear el usuario" });

                        if (usuario.Equals("ErrorPassword"))
                            return Json(new { isValid = false, tipoError = "error", error = "Error Password" });


                        return Json(new { isValid = true, operacion = "crear" });
                    }
                    catch (Exception)
                    {

                        return Json(new { isValid = false, tipoError = "error", error = "Error al crear el registro" });
                    }
                }
                else
                {
                    return Json(new { isValid = false, tipoError = "warning", error = "El usuario ya existe" });
                }
            }
            return Json(new { isValid = false, tipoError = "warning", error = "Debe diligenciar los campos requeridos" });
        }

        public IActionResult login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> login(LoginDTO login)
        {
            if (ModelState.IsValid)
            {

                var result = await _signInManager.PasswordSignInAsync(login.Email, login.Password, login.RecordarMe, false);
                if (result.Succeeded)
                    return RedirectToAction("Usuarios", "Usuarios");
                return Json(new { isValid = false, tipoError = "error", error = "El usuario no existe" });
            }
            return View();
        }

        public async Task<IActionResult> CerrarSesion()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("login", "usuarios");
        }

        
        public IActionResult OlvidePassword()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> OlvidePassword(RecuperarPasswordDto recuperarPasswordDto)
        {
            if (ModelState.IsValid)
            {
                //buscamos si el email existe
                var usuario = await _userManager.FindByEmailAsync(recuperarPasswordDto.Email);
                if (usuario != null)
                {
                    //generamos un token
                    var token = await _userManager.GeneratePasswordResetTokenAsync(usuario);
                    //creamos un link para resetear el password
                    var passwordresetLink = Url.Action("ReseteoPassword", "Usuarios",
                        new { email = recuperarPasswordDto.Email, token = token }, Request.Scheme);

                    //Metodo tradicional de enviar correos por smtp
                    MailMessage mensaje = new();
                    mensaje.To.Add(recuperarPasswordDto.Email); //destinatario
                    mensaje.Subject = "recuperar password";
                    mensaje.Body = passwordresetLink;
                    mensaje.IsBodyHtml = false;

                    mensaje.From = new MailAddress("jcatehortua14@misena.edu.co", "ComputerSena");
                    SmtpClient smtpClient = new("smtp.gmail.com");
                    smtpClient.Port = 587;
                    smtpClient.UseDefaultCredentials = false;
                    smtpClient.EnableSsl = true;
                    smtpClient.Credentials = new System.Net.NetworkCredential("jcatehortua14@misena.edu.co", "Camilohijo02");
                    smtpClient.Send(mensaje);

                }
            }
            return View();
        }

        [HttpGet]
        public IActionResult ReseteoPassword(string token, string email)
        {
            if (token == null || email == null)
            {
                ModelState.AddModelError("", "Error en Token");

            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ReseteoPassword(ReseteoPasswordDto reseteoPasswordDto)
        {
            if (ModelState.IsValid)
            {

                var usuario = await _userManager.FindByEmailAsync(reseteoPasswordDto.Email);
                if (usuario != null)
                {
                    var result = await _userManager.ResetPasswordAsync(usuario, reseteoPasswordDto.Token, reseteoPasswordDto.Password);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("login", "Usuarios");

                    }
                }
            }
            return View();
        }
    }
}
