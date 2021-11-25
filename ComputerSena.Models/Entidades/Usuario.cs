using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerSena.Models.Entidades
{

    public class Usuario : IdentityUser
    {
        [Required(ErrorMessage = "El Nombre del Usuario es requerido")]
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        [Required(ErrorMessage = "El  Documento es requerido")]
        
        public string Documento { get; set; }
        [Required(ErrorMessage = "El  Cargo es requerido")]
        public string Cargo { get; set; }
        [Required(ErrorMessage = "El  Rol es requerido")]
        public int RolID { get; set; }
        [Required(ErrorMessage = "El  Tipo de Documento es requerido")]
        public int TipoDocumentoID { get; set; }
        public virtual Rol Rol { get; set; }
        public virtual TipoDocumento TipoDocumento { get; set; }
        public bool Estado { get;set; }
    }
}
