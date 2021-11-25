using ComputerSena.Models.Entidades;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerSena.DAL
{
    public class AppDbContext : IdentityDbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> option): base(option)
        {

        }

        public DbSet<EntradaSalida> EntradaSalidas { get; set; }
        public DbSet<Rol> Roles { get; set; }
        public DbSet<TipoDocumento> TiposDocumento { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}
