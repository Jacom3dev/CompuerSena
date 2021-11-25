using ComputerSena.Models.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerSena.Servicios.Interfaces
{
    public interface IRolServicios
    {
        Task<IEnumerable<Rol>> ListarRoles();
        Task<Rol> GetRoles(int ID);
        void EditarRoles(Rol rol);
        Task<bool> GuardarCambios();

    }
}
