using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerSena.Models.Entidades
{
    public class TipoDocumento
    {
        [Key]
        public int TipoDocumentoID { get; set; }
        public string Nombre { get; set; }
        public virtual List<Usuario> Usuarios { get; set; }
    }
}
