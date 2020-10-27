using API_Pets.Domains;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Pets.Context
{
    public class PetContext : DbContext
    {
        public DbSet<Raca> Racas { get; set; }
        public DbSet<TipoPet> TipoDePets { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer(@"Data source=.\SQLEXPRESS;Initial Catalog=Pets;user id=sa;password=sa132");
            base.OnConfiguring(optionsBuilder);
        }

        internal SqlConnection Conectar()
        {
            throw new NotImplementedException();
        }

        internal void Desconectar()
        {
            throw new NotImplementedException();
        }
    }
}
