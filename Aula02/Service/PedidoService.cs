using Aula02.Model;
using Aula02.Repository;
using System.Collections.Generic;

namespace Aula02.Service
{
    /// <summary>
    /// 
    /// </summary>
    public class PedidoService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public Pedido GetById(int Id)
        {
            var repository = new PedidoRepository();
            return repository.GetById(Id);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Pedido> GetAll()
        {
            var repository = new PedidoRepository();
            return repository.GetAll();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pedido"></param>
        public void Inserir(Pedido pedido)
        {
            var repository = new PedidoRepository();
            repository.Insert(pedido);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pedido"></param>
        public void Alterar(Pedido pedido)
        {
            var repository = new PedidoRepository();
            repository.Update(pedido);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        public void Remover(int id)
        {
            var repository = new PedidoRepository();
            repository.Delete(id);
        }
    }
}