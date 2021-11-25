using ComputerSena.Models.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerSena.Servicios.DTOS
{
   public class UsuarioDto
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public bool Estado { get; set; }
    }
}
