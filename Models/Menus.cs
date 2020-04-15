using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Guarderia.Models
{
    public class Menus
    {
        public int Id { get; set; }
        public string Plato1 { get; set; }
        public string Plato2 { get; set; }
        public string Plato3 { get; set; }
        public string Ingrediente { get; set; }
        public decimal Costo { get; set; }
    }
}