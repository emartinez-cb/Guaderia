using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Guarderia.Models
{
    public class Ninos
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Alergias { get; set; }
        public string FechaDeBaja { get; set; }
        public string Matricula { get; set; }

        public string Recogedor { get; set; }

        public string FechaDeIngreso { get; set; }
        public string FechaDeNacimiento { get; set; }
    }
}