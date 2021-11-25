using ComputerSena.Models.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerSena.Servicios.DTOS
{
    public class RegistrarUsuarioDto
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
        [Required(ErrorMessage = "El email es requerido")]
        [Display(Name = "Email", Order = -9,
         Prompt = "Ingrese el email", Description = "Email")]
        [EmailAddress(ErrorMessage = "Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "La contraseña es requerida")]
        [Display(Name = "Contraseña", Order = -7,
        Prompt = "Ingrese la contraseña", Description = "Contraseña")]
        [DataType(DataType.Password)]
        [StringLength(20, ErrorMessage = "El {0} debe tener al menos {2} y maximo {1} caracteres.", MinimumLength = 9)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirmar contraseña", Order = -7,
        Prompt = "Confirme la contraseña", Description = "Confirme la contraseña")]
        [Compare("Password",
            ErrorMessage = "El Password y confirmar password debe coincidir")]
        public string ConfirmarPassword { get; set; }
    }
}
