using Aula02.Model;
using Aula02.Service;
using System.Collections.Generic;
using System.Web.Http;

namespace Aula02.Controller
{
    /// <summary>
    /// Classe controller de PEDIDO aqui terão os métodos de CRUD de acesso externo da API
    /// </summary>
    [RoutePrefix("api/pedido")]
    public class PedidoController : ApiController
    {
        /// <summary>
        /// Método responsável por trazer todos os pedidos
        /// </summary>
        /// <returns></returns>
        // GET api/<controller>
        [Route("")]
        public IEnumerable<Pedido> Get()
        {
            var service = new PedidoService();
            return service.GetAll();
        }

        /// <summary>
        /// Método responsável por retornar um pedido de acordo com o ID passado
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        // GET api/<controller>/5
        [Route("{id}")]
        public Pedido Get(int id)
        {
            var service = new PedidoService();
            return service.GetById(id);
        }

        /// <summary>
        /// Método responsável por Inserir um pedido
        /// </summary>
        /// <param name="pedido"></param>
        // POST api/<controller>
        [Route("")]
        public void Post([FromBody]Pedido pedido)
        {
            var service = new PedidoService();
            service.Inserir(pedido);
        }

        /// <summary>
        /// Método responsável por Alterar um pedido
        /// </summary>
        /// <param name="id"></param>
        /// <param name="pedido"></param>
        // PUT api/<controller>/5
        [Route("")]
        public void Put(int id, [FromBody]Pedido pedido)
        {
            var service = new PedidoService();
            service.Alterar(pedido);
        }

        /// <summary>
        /// Método responsável por Remover um pedido
        /// </summary>
        /// <param name="id"></param>
        // DELETE api/<controller>/5
        [Route("")]
        public void Delete(int id)
        {
            var service = new PedidoService();
            service.Remover(id);
        }
    }
}