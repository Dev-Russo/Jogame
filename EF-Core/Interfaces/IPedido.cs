using EFCore.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EF_Core.Interfaces
{
    interface IPedido
    {
        /// <summary>
        /// Lista todos os pedidos
        /// </summary>
        /// <returns>Retorna uma lista de pedidos</returns>
        List<Pedido> Listar();

        /// <summary>
        /// Adiciona um novo pedido
        /// </summary>
        /// <param name="pedidosItens">Lista de pedidos itens</param>
        /// <returns>Objeto Pedido</returns>
        Pedido Adicionar(List<PedidoItem> pedidosItens);
    }
}
