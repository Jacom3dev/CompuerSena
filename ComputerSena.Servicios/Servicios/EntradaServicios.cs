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
    public class EntradaServicios : IEntradaServicios
    {
        private readonly AppDbContext _context;
        public EntradaServicios(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<EntradaSalida>> ListarEntrada()
        {
            return await _context.EntradaSalidas.Where(x=> x.Estado == true).ToListAsync();
        }

        public void CrearEntrada (EntradaSalida entrada)
        {
            if (entrada == null)
                throw new ArgumentNullException(nameof(entrada));
            entrada.Estado = true;
            entrada.FechaEntrada = DateTime.Now;
            _context.Add(entrada);
        }


        public async Task<bool> GuardarCambios()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
