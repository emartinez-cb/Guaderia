using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;


namespace Guarderia.Models
{
    public class GuarderiaContext: DbContext
    {
        public GuarderiaContext()
            :base("Guarderia")
        {

        }

        public DbSet<Ninos> Ninos { get; set; }
        public DbSet<Recogedores> Recogedores { get; set; }
        public DbSet<Pagadores> Pagadores { get; set; }
        public DbSet<Menus> Menus { get; set; }
        public DbSet<ComidaPn> ComidaPn { get; set; }
  
    }
}