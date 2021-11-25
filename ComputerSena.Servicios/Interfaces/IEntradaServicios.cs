using ComputerSena.Models.Entidades;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerSena.Servicios.Interfaces
{
    public interface IEntradaServicios
    {
        Task<IEnumerable<EntradaSalida>> ListarEntrada();
        void CrearEntrada(EntradaSalida entrada);
        Task<bool> GuardarCambios();
    }
}
