using Aula02.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Aula02.Repository
{
    /// <summary>
    /// 
    /// </summary>
    public class PedidoRepository
    {
        /// <summary>
        /// Lista que será usada como nosso banco de dados
        /// </summary>
        private static List<Pedido> _listaPedido;

        /// <summary>
        /// Método construtor que irá popular a lista quando instanciado
        /// </summary>
        public PedidoRepository()
        {
            PopularLista();
        }

        /// <summary>
        /// Método responsável por popular a lista 
        /// </summary>
        /// <returns></returns>
        private List<Pedido> PopularLista()
        {
            if (_listaPedido == null)
            {
                _listaPedido = new List<Pedido>();

                var clienteRepository = new ClienteRepository();
                var produtoRepository = new ProdutoRepository();

                CriarPrimeiroPedido(clienteRepository, produtoRepository);

                CriarSegundoPedido(clienteRepository, produtoRepository);
            }

            return _listaPedido;
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
            _listaPedido.Add(pedido);
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
            _listaPedido.Add(pedido);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Pedido GetById(int id)
        {
            return _listaPedido.Where(p => p.Id == id).FirstOrDefault();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Pedido> GetAll()
        {
            return _listaPedido;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        public void Delete(int id)
        {
            var pedidoAux = GetById(id);

            if (pedidoAux != null)
                _listaPedido.Remove(pedidoAux);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pedido"></param>
        public void Update(Pedido pedido)
        {
            var pedidoAux = GetById(pedido.Id);

            if (pedidoAux != null)
            {
                _listaPedido.Remove(pedidoAux);

                _listaPedido.Add(pedido);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pedido"></param>
        public void Insert(Pedido pedido)
        {
            _listaPedido.Add(pedido);
        }
    }
}