using Aula02.Model;
using System.Collections.Generic;
using System.Linq;

namespace Aula02.Repository
{
    /// <summary>
    /// 
    /// </summary>
    public class ProdutoRepository
    {
        /// <summary>
        /// Lista que será usada como nosso banco de dados
        /// </summary>
        private static List<Produto> _listaProduto;

        /// <summary>
        /// Método construtor que irá popular a lista quando instanciado
        /// </summary>
        public ProdutoRepository()
        {
            PopularLista();
        }

        /// <summary>
        /// Método responsável por popular a lista 
        /// </summary>
        /// <returns></returns>
        private List<Produto> PopularLista()
        {
            if (_listaProduto == null)
            {
                _listaProduto = new List<Produto>
                {
                    new Produto() { Id = 1, Descricao = "Cinto", EstoqueMinimo = 5, Quantidade = 3, Valor = 50 },
                    new Produto() { Id = 2, Descricao = "Bolsa", EstoqueMinimo = 2, Quantidade = 5, Valor = 250 },
                    new Produto() { Id = 3, Descricao = "Bola", EstoqueMinimo = 10, Quantidade = 20, Valor = 10 },
                    new Produto() { Id = 4, Descricao = "Carteira", EstoqueMinimo = 3, Quantidade = 2, Valor = 30 },
                    new Produto() { Id = 5, Descricao = "Bone", EstoqueMinimo = 6, Quantidade = 1, Valor = 100 }
                };
            }

            return _listaProduto;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Produto GetById(int id)
        {
            return _listaProduto.Where(p => p.Id == id).FirstOrDefault();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Produto> GetAll()
        {
            return _listaProduto;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        public void Delete(int id)
        {
            var produtoAux = GetById(id);

            if (produtoAux != null)
                _listaProduto.Remove(produtoAux);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="produto"></param>
        public void Update(Produto produto)
        {
            var produtoAux = GetById(produto.Id);

            if (produtoAux != null)
            {
                _listaProduto.Remove(produtoAux);

                _listaProduto.Add(produto);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="produto"></param>
        public void Insert(Produto produto)
        {
            _listaProduto.Add(produto);
        }
    }
}