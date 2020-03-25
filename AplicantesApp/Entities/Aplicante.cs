using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AplicantesApp.Entities
{
    
    public class Aplicante
    {   
        [Key]
        public int codigo { get; set; }
        public string nombre { get; set; }
        public string correo_electronico { get; set; }
        public string direccion { get; set; }
    }
}
