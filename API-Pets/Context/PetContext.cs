using API_Pets.Domains;
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
        public DbSet<TipoDePet> TipoDePets { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer(@"Data source=.\SQLEXPRESS;Initial Catalog=Pets;user id=sa;password=sa132");
            base.OnConfiguring(optionsBuilder);
        }

    }
}
