using System;
using System.Collections.Generic;
using EF_Core.Interfaces;
using EFCore.Domains;
using EFCore.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace EFCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidoController : ControllerBase
    {
        private readonly IPedido _pedidoRepository;

        public PedidoController()
        {
            _pedidoRepository = new PedidoRepository();
        }

        [HttpPost]
        public IActionResult Post(List<PedidoItem> pedidosItens)
        {
            try
            {
                //Adiciona um novo pedido com os itens do pedido
                Pedido pedido = _pedidoRepository.Adicionar(pedidosItens);

                //Caso ok retorna o pedido
                return Ok(pedido);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var pedidos = _pedidoRepository.Listar();

                if (pedidos.Count == 0)
                    return NoContent();

                return Ok(pedidos);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}