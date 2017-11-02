using Aula02.Model;
using Aula02.Repository;
using System.Collections.Generic;
using System.Linq;

namespace Aula02.Service
{
    /// <summary>
    /// 
    /// </summary>
    public class ProdutoService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public Produto GetById(int Id)
        {
            var repository = new ProdutoRepository();
            return repository.GetById(Id);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Produto> GetAll()
        {
            var repository = new ProdutoRepository();
            return repository.GetAll();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Produto> GetProdutosEstoqueAbaixoMinimo()
        {
            var repository = new ProdutoRepository();
            return repository.GetAll().Where(p => p.Quantidade < p.EstoqueMinimo).ToList();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="produto"></param>
        public void Inserir(Produto produto)
        {
            var repository = new ProdutoRepository();
            repository.Insert(produto);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="produto"></param>
        public void Alterar(Produto produto)
        {
            var repository = new ProdutoRepository();
            repository.Update(produto);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        public void Remover(int id)
        {
            var repository = new ProdutoRepository();
            repository.Delete(id);
        }
    }
}