using Aula02.Model;
using Aula02.Repository.Base;
using System.Collections.Generic;
using System.Linq;

namespace Aula02.Repository
{
    /// <summary>
    /// 
    /// </summary>
    public sealed class ProdutoRepository : BaseRepository<Produto>
    {
        /// <summary>
        /// Método responsável por popular a lista 
        /// </summary>
        /// <returns></returns>
        protected override List<Produto> PopularLista()
        {
            _lista = new List<Produto>
            {
                new Produto() { Id = 1, Descricao = "Cinto", EstoqueMinimo = 5, Quantidade = 3, Valor = 50 },
                new Produto() { Id = 2, Descricao = "Bolsa", EstoqueMinimo = 2, Quantidade = 5, Valor = 250 },
                new Produto() { Id = 3, Descricao = "Bola", EstoqueMinimo = 10, Quantidade = 20, Valor = 10 },
                new Produto() { Id = 4, Descricao = "Carteira", EstoqueMinimo = 3, Quantidade = 2, Valor = 30 },
                new Produto() { Id = 5, Descricao = "Bone", EstoqueMinimo = 6, Quantidade = 1, Valor = 100 }
            };

            return _lista;
        }
       
    }
}