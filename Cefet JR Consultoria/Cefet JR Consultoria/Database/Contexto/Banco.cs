using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Cefet_JR_Consultoria.Database.Conceitual;

namespace Cefet_JR_Consultoria.Database.Contexto
{
    class Banco:DbContext
    {
        public Banco()
            : base("name=Banco") { }
       
        public virtual DbSet<Usuario> usuarios { get; set; }
    }
}
