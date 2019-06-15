using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_Consulta.Entidades;
using System.Data.Entity;

namespace Sistema_Consulta.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Usuarios> Usuario { get; set; }
        public DbSet<Cargos> Cargo { get; set; }

        public DbSet<Analisis> Analisi { get; set; }
        public DbSet<TipoAnalisis> TipoAnalisi { get; set; }
        public Contexto() : base("ConStr")
        {

        }
    }
    
}
