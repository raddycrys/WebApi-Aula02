using Aula02.Model;
using Aula02.Service;
using System.Collections.Generic;
using System.Web.Http;

namespace Aula02.Controller
{
    /// <summary>
    /// Classe controller de PRODUTO aqui terão os métodos de CRUD de acesso externo da API
    /// </summary>
    [RoutePrefix("api/produto")]
    public class ProdutoController : ApiController
    {
        /// <summary>
        /// Método responsável por trazer todos os produtos
        /// </summary>
        /// <returns></returns>
        // GET api/<controller>
        [Route("")]
        public IEnumerable<Produto> Get()
        {
            var service = new ProdutoService();
            return service.GetAll();
        }

        /// <summary>
        /// Método responsável por trazer todos os produtos com o estoque abaixo do mínimo
        /// </summary>
        /// <returns></returns>
        [Route("getProdutosEstoqueAbaixoMinimo")]
        public IEnumerable<Produto> GetProdutosEstoqueAbaixoMinimo()
        {
            var service = new ProdutoService();
            return service.GetProdutosEstoqueAbaixoMinimo();
        }

        /// <summary>
        /// Método responsável por retornar um produto de acordo com o ID passado
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        // GET api/<controller>/5
        [Route("{id}")]
        public Produto Get(int id)
        {
            var service = new ProdutoService();
            return service.GetById(id);
        }

        /// <summary>
        /// Método responsável por Inserir um produto
        /// </summary>
        /// <param name="produto"></param>
        // POST api/<controller>
        [Route("")]
        public void Post([FromBody]Produto produto)
        {
            var service = new ProdutoService();
            service.Inserir(produto);
        }

        /// <summary>
        /// Método responsável por Alterar um produto
        /// </summary>
        /// <param name="id"></param>
        /// <param name="produto"></param>
        // PUT api/<controller>/5
        [Route("")]
        public void Put(int id, [FromBody]Produto produto)
        {
            var service = new ProdutoService();
            service.Alterar(produto);
        }

        /// <summary>
        /// Método responsável por Remover um produto
        /// </summary>
        /// <param name="id"></param>
        // DELETE api/<controller>/5
        [Route("")]
        public void Delete(int id)
        {
            var service = new ProdutoService();
            service.Remover(id);
        }
    }
}