using ComputerSena.Models.Entidades;
using ComputerSena.Servicios.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerSena.Servicios.Interfaces
{
    public interface IUsuarioServicios
    {

        Task<IEnumerable<Usuario>> ListarUsuarios();
        Task<IEnumerable<TipoDocumento>> TiposDocumento();
        Task<IEnumerable<Rol>> Roles();
        Task<UsuarioDto> GetUserDtoforEmail(string email);
        Task<String> Create(RegistrarUsuarioDto registrarUserDto);
        Task<bool> GuardarCambios();
    }

}