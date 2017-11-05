using Aula02.Model;
using Aula02.Repository.Base;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Aula02.Repository
{
    /// <summary>
    /// 
    /// </summary>
    public sealed class PedidoRepository : BaseRepository<Pedido>
    {
        /// <summary>
        /// Método responsável por popular a lista 
        /// </summary>
        /// <returns></returns>
        protected override List<Pedido> PopularLista()
        {
            _lista = new List<Pedido>();

            var clienteRepository = new ClienteRepository();
            var produtoRepository = new ProdutoRepository();

            CriarPrimeiroPedido(clienteRepository, produtoRepository);

            CriarSegundoPedido(clienteRepository, produtoRepository);

            return _lista;
        }

        private static void CriarPrimeiroPedido(ClienteRepository clienteRepository, ProdutoRepository produtoRepository)
        {
            // - Cria um novo pedido 
            var pedido = new Pedido() { Id = 1, DataEmissao = DateTime.Today };

            // - Busca um cliente pra referenciar da tabela de cliente
            pedido.Cliente = clienteRepository.GetById(1);

            // - Coloca um item dentro dele 
            var item = new ItemPedido() { Id = 1, Quantidade = 1, Valor = 30 };

            // - Busca um produto pra referenciar da tabela de produto
            item.Produto = produtoRepository.GetById(1);

            // - Coloca o item no pedido 
            pedido.Itens.Add(item);

            // - Coloca um item dentro dele 
            item = new ItemPedido() { Id = 2, Quantidade = 1, Valor = 30 };

            // - Busca um produto pra referenciar da tabela de produto
            item.Produto = produtoRepository.GetById(3);

            // - Coloca o item no pedido 
            pedido.Itens.Add(item);

            // - Coloca o pedido na lista
            _lista.Add(pedido);
        }

        private static void CriarSegundoPedido(ClienteRepository clienteRepository, ProdutoRepository produtoRepository)
        {
            // - Cria um novo pedido 
            var pedido = new Pedido() { Id = 2, DataEmissao = DateTime.Today.AddDays(-1) };

            // - Busca um cliente pra referenciar da tabela de cliente
            pedido.Cliente = clienteRepository.GetById(2);

            // - Coloca um item dentro dele 
            var item = new ItemPedido() { Id = 1, Quantidade = 1, Valor = 100 };

            // - Busca um produto pra referenciar da tabela de produto
            item.Produto = produtoRepository.GetById(2);

            // - Coloca o item no pedido 
            pedido.Itens.Add(item);

            // - Coloca um item dentro dele 
            item = new ItemPedido() { Id = 2, Quantidade = 1, Valor = 50 };

            // - Busca um produto pra referenciar da tabela de produto
            item.Produto = produtoRepository.GetById(3);

            // - Coloca o item no pedido 
            pedido.Itens.Add(item);

            // - Coloca o pedido na lista
            _lista.Add(pedido);
        }
    }
}