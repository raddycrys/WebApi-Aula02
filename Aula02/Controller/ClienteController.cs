using Aula02.Model;
using Aula02.Service;
using System.Collections.Generic;
using System.Web.Http;

namespace Aula02.Controller
{
    /// <summary>
    /// Classe controller de CLIENTE aqui terão os métodos de CRUD de acesso externo da API
    /// </summary>
    [RoutePrefix("api/cliente")]
    public class ClienteController : ApiController
    {
        /// <summary>
        /// Método responsável por trazer todos os clientes
        /// </summary>
        /// <returns></returns>
        // GET api/<controller>
        [Route("getAllOrdemAlfabetica")]
        public IEnumerable<Cliente> Get()
        {
            var service = new ClienteService();
            return service.GetAllOrdemAlfabetica();
        }

        /// <summary>
        /// Método responsável por trazer uma lista com os clientes de um sexo específico
        /// </summary>
        /// <param name="tipoSexo"></param>
        /// <returns></returns>
        [Route("getBySexo/{tipoSexo}")]
        public IEnumerable<Cliente> GetBySexo(TipoSexo tipoSexo)
        {
            var service = new ClienteService();
            return service.GetBySexo(tipoSexo);
        }

        /// <summary>
        /// Método responsável por trazer uma lista com os clientes ativos
        /// </summary>
        /// <returns></returns>
        [Route("getClientesAtivos")]
        public IEnumerable<Cliente> GetClientesAtivos()
        {
            var service = new ClienteService();
            return service.GetClientesAtivos();
        }

        /// <summary>
        /// Método responsável por trazer os aniversariantes de um dia/mes específico
        /// </summary>
        /// <param name="dia"></param>
        /// <param name="mes"></param>
        /// <returns></returns>
        [Route("getAniversariantes/{dia}/{mes}")]
        public IEnumerable<Cliente> GetAniversariantes(int dia, int mes)
        {
            var service = new ClienteService();
            return service.GetAniversariantes(dia,mes);
        }

        /// <summary>
        /// Método responsável por retornar um cliente de acordo com o ID passado
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        // GET api/<controller>/5
        [Route("{id}")]
        public Cliente Get(int id)
        {
            var service = new ClienteService();
            return service.GetById(id);
        }

        /// <summary>
        /// Método responsável por Inserir um cliente
        /// </summary>
        /// <param name="cliente"></param>
        // POST api/<controller>
        [Route("")]
        public void Post([FromBody]Cliente cliente)
        {
            var service = new ClienteService();
            service.Inserir(cliente);
        }

        /// <summary>
        /// Método responsável por Alterar um cliente
        /// </summary>
        /// <param name="cliente"></param>
        // PUT api/<controller>/5
        [Route("")]
        public void Put([FromBody]Cliente cliente)
        {
            var service = new ClienteService();
            service.Alterar(cliente);
        }

        /// <summary>
        /// Método responsável por ativar ou inativar o cliente
        /// </summary>
        /// <param name="id"></param>
        /// <param name="ativar"></param>
        [Route("AtivaOrInativa/{id}/{ativar}")]
        public void Put(int id, bool ativar)
        {
            var service = new ClienteService();
            service.AtivaOrInativa(id,ativar);
        }

        /// <summary>
        /// Método responsável por Remover um cliente
        /// </summary>
        /// <param name="id"></param>
        // DELETE api/<controller>/5
        [Route("")]
        public void Delete(int id)
        {
            var service = new ClienteService();
            service.Remover(id);
        }
    }
}