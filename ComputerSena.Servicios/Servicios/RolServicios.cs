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
    public class RolServicios : IRolServicios
    {


        private readonly AppDbContext _context;

        public RolServicios(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Rol>> ListarRoles()
        {
            return await _context.Roles.ToListAsync();

        }

        public async Task<Rol> GetRoles(int ID)
        {
            if (ID == 0)
                throw new ArgumentNullException(nameof(ID));

            return await _context.Roles.FirstOrDefaultAsync(x => x.RolID == ID);
        }

        public void EditarRoles(Rol rol)
        {
            if (rol == null)
                throw new ArgumentNullException(nameof(rol));
            _context.Update(rol);
        }
        public async Task<bool> GuardarCambios()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
