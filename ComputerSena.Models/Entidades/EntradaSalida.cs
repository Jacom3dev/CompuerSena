using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerSena.Models.Entidades
{
    public class EntradaSalida
    {
        [Key]
        public int EntradaSalidaID { get; set; }
        [Required(ErrorMessage = "El  Nombre del propietario es requerido")]
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        [Required(ErrorMessage = "El  Documento del propietario es requerido")]
        public string Documento { get; set; }
        [Required(ErrorMessage = "El  elemento es requerido")]
        public string Elemento { get; set; }
        [Required(ErrorMessage = "El  Color es requerido")]
        public string Color { get; set; }
        [Required(ErrorMessage = "El  Serial es requerido")]
        public string Serial { get; set; }
        [Required(ErrorMessage = "La  Fecha de entrada es requerido")]
        public DateTime FechaEntrada { get; set; }
        public DateTime FechaSalida { get; set; }
        public bool Estado { get; set; }

    }
}
