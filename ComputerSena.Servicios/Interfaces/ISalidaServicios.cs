﻿using ComputerSena.Models.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerSena.Servicios.Interfaces
{
    public interface ISalidaServicios
    {
        Task<IEnumerable<EntradaSalida>> ListarSalidas();
        Task<bool> GuardarCambios();
    }
}
