using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonasEF2022.Modelos
{
    public class PersonasDbContext:DbContext
    {
        public PersonasDbContext():base("MiConexion")
        {
            
        }

        public DbSet<Persona> Personas { get; set; }
    }
}
