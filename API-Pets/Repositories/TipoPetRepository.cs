using API_Pets.Domains;
using API_Pets.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Pets.Repositories
{
    public class TipoPetRepository : ITipoPet
    {
        //conectar com o banco com o context
        PetsContext conexao = new PetsContext();

        SqlCommand cmd = new SqlCommand();

        public TipoPet Alterar(TipoPet p)
        {
            throw new NotImplementedException();
        }

        public TipoPet BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public TipoPet Cadastrar(TipoPet p)
        {
            throw new NotImplementedException();
        }

        public void Excluir(int id)
        {
            throw new NotImplementedException();
        }

        public List<TipoPet> LerTodos()
        {
            throw new NotImplementedException();
        }
    }
}
