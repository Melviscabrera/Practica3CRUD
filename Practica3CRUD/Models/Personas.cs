using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Practica3CRUD.Models
{
    public partial class Personas
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public int Edad { get; set; }
        public List <Direccion> direccion { get; set; }
    }
    public partial class Direccion
    {
        [Key]
        public int Iddireccion { get; set; }
        public string Calle { get; set; }
        public string Sector { get; set; }
        public string Municipio { get; set; }
        public string Provincia { get; set; }
        public int Idpersona { get; set; }
        public Personas Personas { get; set; }
    }
}
