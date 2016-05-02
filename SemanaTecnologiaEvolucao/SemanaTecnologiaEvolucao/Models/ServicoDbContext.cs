using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SemanaTecnologiaEvolucao.Models
{
    public class ServicoDbContext : DbContext
    {
        public ServicoDbContext()
            : base("SyberDB")
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<ServicoDbContext>());
        }

        public DbSet<Usuario> Usuario { get; set; }
    }
}