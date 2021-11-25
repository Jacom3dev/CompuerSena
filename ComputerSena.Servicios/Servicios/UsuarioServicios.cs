using ComputerSena.DAL;
using ComputerSena.Models.Entidades;
using ComputerSena.Servicios.DTOS;
using ComputerSena.Servicios.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerSena.Servicios.Servicios
{
    public class UsuarioServicios : IUsuarioServicios //contrato
    {
        private readonly AppDbContext _context;
        private readonly UserManager<Usuario> _usermanager;

        public UsuarioServicios(UserManager<Usuario> usermanager, AppDbContext context)
        {
            _usermanager = usermanager;
            _context = context;
        }


        public async Task<IEnumerable<Usuario>> ListarUsuarios()
        {
            return await _context.Usuarios.Include(x=>x.TipoDocumento).Include(x=>x.Rol).ToListAsync();
        }

        public async Task<IEnumerable<TipoDocumento>> TiposDocumento()
        {
            return await _context.TiposDocumento.ToListAsync();
        }
        public async Task<IEnumerable<Rol>> Roles()
        {
            return await _context.Roles.ToListAsync();
        }


        public async Task<String> Create(RegistrarUsuarioDto registrarUserDto)
        {
            if (registrarUserDto == null)
                throw new ArgumentNullException(nameof(registrarUserDto));
            Usuario usuario = new()
            {
                Nombre = registrarUserDto.Nombre,
                Apellido = registrarUserDto.Apellido,
                Documento = registrarUserDto.Documento,
                Cargo = registrarUserDto.Cargo,
                RolID = registrarUserDto.RolID,
                TipoDocumentoID = registrarUserDto.TipoDocumentoID,
                UserName = registrarUserDto.Email,
                Email = registrarUserDto.Email,
                Estado = true,
            };
            var result = await _usermanager.CreateAsync(usuario, registrarUserDto.Password);
            if (result.Errors.Any())
                return "ErrorPassword";

            if (result.Succeeded)
                return usuario.Id;
            return null;
        }
        public async Task<UsuarioDto> GetUserDtoforEmail(string email)
        {
            if (email == null)

                throw new ArgumentNullException(nameof(email));
            var usuario = await _usermanager.FindByEmailAsync(email);
            if (usuario != null)
            {
                UsuarioDto usuarioDto = new()
                {
                    Id = usuario.Id,
                    Email = usuario.Email,
                    Estado = usuario.Estado
                };
                return usuarioDto;
            }

            return null;
        }
        public async Task<bool> GuardarCambios()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
