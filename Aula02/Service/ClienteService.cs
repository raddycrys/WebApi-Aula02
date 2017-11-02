using Aula02.Model;
using Aula02.Repository;
using System.Collections.Generic;
using System.Linq;

namespace Aula02.Service
{
    /// <summary>
    /// Classe de Cliente responsável pelas regras de negócio
    /// </summary>
    public class ClienteService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public Cliente GetById(int Id)
        {
            var repository = new ClienteRepository();
            return repository.GetById(Id);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Cliente> GetAllOrdemAlfabetica()
        {
            var repository = new ClienteRepository();
            return repository.GetAll().OrderBy(p => p.Nome).ToList();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tipoSexo"></param>
        /// <returns></returns>
        public List<Cliente> GetBySexo(TipoSexo tipoSexo)
        {
            var repository = new ClienteRepository();
            return repository.GetAll().Where(p => p.Sexo == tipoSexo).ToList();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Cliente> GetClientesAtivos()
        {
            var repository = new ClienteRepository();
            return repository.GetAll().Where(p => p.Ativo == true).ToList();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Cliente> GetAniversariantes(int dia, int mes)
        {
            var repository = new ClienteRepository();

            return repository.GetAll().Where(p => p.DataNascimento.GetValueOrDefault().Day == dia && p.DataNascimento.GetValueOrDefault().Month == mes).ToList();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cliente"></param>
        public void Inserir(Cliente cliente)
        {
            var repository = new ClienteRepository();
            repository.Insert(cliente);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cliente"></param>
        public void Alterar(Cliente cliente)
        {
            var repository = new ClienteRepository();
            repository.Update(cliente);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="ativar"></param>
        public void AtivaOrInativa(int id, bool ativar)
        {
            var repository = new ClienteRepository();
            repository.AtivaOrInativa(id, ativar);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        public void Remover(int id)
        {
            var repository = new ClienteRepository();
            repository.Delete(id);
        }
    }
}