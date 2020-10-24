using API_Pets.Context;
using API_Pets.Domains;
using API_Pets.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Pets.Repositories
{
    public class RacaRepository : IRaca
    {
        private PetContext context;
        //Construtor
        public RacaRepository()
        {
            context = new PetContext();
        }
        public void Delete(int id)
        {
            try
            {
                Raca raca = context.Racas.Find(id);
                context.Racas.Remove(raca);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public Raca Find(int Id)
        {
            try
            {
                return context.Racas.Find(Id);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public Raca Inserir(Raca entity)
        {
            throw new NotImplementedException();
        }

        public List<Raca> List()
        {
            throw new NotImplementedException();
        }

        public Raca Update(Raca entity)
        {
            throw new NotImplementedException();
        }
    }
}
