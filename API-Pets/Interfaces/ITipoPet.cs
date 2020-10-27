using API_Pets.Domains;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Pets.Interfaces
{
    interface ITipoPet 
    {
        //utilizando crud

        //create
        TipoPet Cadastrar(TipoPet p);

        //listando as racas
        List<TipoPet> LerTodos();

        //busca por id
        TipoPet BuscarPorId(int id);

        //alterar
        TipoPet Alterar(TipoPet p);

        //delete
        void Excluir(int id);
    }
}
