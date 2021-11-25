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
    public class entradasalidaServicios : IEntradaSalidaServicios
    {
        private readonly AppDbContext _context;

        public entradasalidaServicios(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<EntradaSalida>> ListarEntradaSalidas()
        {
            return await _context.EntradaSalidas.ToListAsync();
        }

        public async Task<EntradaSalida> GetEntradaSalida(int ID)
        {
            if (ID == 0)
                throw new ArgumentNullException(nameof(ID));

            return await _context.EntradaSalidas.FirstOrDefaultAsync(x => x.EntradaSalidaID == ID);
        }

        public void ActualizarEntradaSalida(EntradaSalida entradaSalida)
        {
            if (entradaSalida == null)
                throw new ArgumentNullException(nameof(entradaSalida));
            _context.Update(entradaSalida);
        }

        public async Task<bool> GuardarCambios()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
