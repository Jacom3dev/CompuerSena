using ComputerSena.Models.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerSena.Servicios.Interfaces
{
    public interface IEntradaSalidaServicios
    {
        Task<IEnumerable<EntradaSalida>> ListarEntradaSalidas();
        void ActualizarEntradaSalida(EntradaSalida entradaSalida);
        Task<EntradaSalida> GetEntradaSalida(int ID);
        Task<bool> GuardarCambios();
    }
}
