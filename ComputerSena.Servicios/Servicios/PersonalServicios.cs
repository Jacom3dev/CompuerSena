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
    public class PersonalServicios : IPersonalServicios
    {
        private readonly AppDbContext _context;

        public PersonalServicios(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<TipoDocumento>> TiposDocumento()
        {
            return await _context.TiposDocumento.ToListAsync();
        }
        public async Task<IEnumerable<Rol>> Roles()
        {
            return await _context.Roles.ToListAsync();
        }


        public async Task<IEnumerable<Usuario>> ListarPersonal()
        {
            return await _context.Usuarios.Include(x => x.TipoDocumento).Include(x => x.Rol).Where(x => x.Rol.RolID == 3).ToListAsync();
        }
    }
}
