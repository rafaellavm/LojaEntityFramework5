using Microsoft.Data.Entity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lojaComEntity.Entitades
{
    public class EntidadesContext: DbContext
    {
        //mapeando a classe Usuario
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string stringConexao = ConfigurationManager.ConnectionStrings["lojaConnectionString"].ConnectionString;
            optionsBuilder.UseSqlServer(stringConexao);
            base.OnConfiguring(optionsBuilder);
        }
    }
}
