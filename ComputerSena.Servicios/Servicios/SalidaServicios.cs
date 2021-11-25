using ComputerSena.DAL;
using ComputerSena.Models.Entidades;
using ComputerSena.Servicios.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerSena.Servicios.Servicios
{
    public class SalidaServicios : ISalidaServicios
    {
        private readonly AppDbContext _context;
        public SalidaServicios(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<EntradaSalida>> ListarSalidas()
        {
            return await _context.EntradaSalidas.Where(x => x.Estado == false).ToListAsync();
        }


        public async Task<bool> GuardarCambios()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
