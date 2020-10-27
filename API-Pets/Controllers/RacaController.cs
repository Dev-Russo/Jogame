using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_Pets.Domains;
using API_Pets.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_Pets.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RacaController : ControllerBase
    {
        //chamando repository
        RacaRepository repo = new RacaRepository();

        // GET: api/<RacaController>
        [HttpGet]
        public List<Raca> Get()
        {
            return repo.LerTodos();
        }

        // GET api/<RacaController>/5
        [HttpGet("{id}")]
        public Raca Get(int id)
        {
            return repo.BuscarPorId(id);
        }

        // POST api/<RacaController>
        [HttpPost]
        public void Post([FromBody] Raca r)
        {
            repo.Cadastrar(r);
        }

        // PUT api/<RacaController>/5
        [HttpPut("{id}")]
        public Raca Put(int id, [FromBody] Raca r)
        {
            return repo.Alterar(r);
        }

        // DELETE api/<RacaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            repo.Excluir(id);
        }
    }
}

