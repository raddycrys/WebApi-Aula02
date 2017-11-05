using Aula02.Model;
using Aula02.Repository;
using Aula02.Service.Base;
using System.Collections.Generic;
using System.Linq;
using Aula02.Repository.Base;

namespace Aula02.Service
{
    /// <summary>
    /// Classe de Cliente responsável pelas regras de negócio
    /// </summary>
    public class ClienteService : BaseService<Cliente>
    {
        private readonly BaseRepository<Cliente> _clienteRepository;

        public ClienteService(BaseRepository<Cliente> baseRepository) : base(baseRepository)
        {
            _clienteRepository = baseRepository;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Cliente> GetAllOrdemAlfabetica()
        {
            return _clienteRepository.GetAll().OrderBy(p => p.Nome).ToList();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tipoSexo"></param>
        /// <returns></returns>
        public List<Cliente> GetBySexo(TipoSexo tipoSexo)
        {
            return _clienteRepository.GetAll().Where(p => p.Sexo == tipoSexo).ToList();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Cliente> GetClientesAtivos()
        {
            return _clienteRepository.GetAll().Where(p => p.Ativo == true).ToList();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Cliente> GetAniversariantes(int dia, int mes)
        {
            return _clienteRepository.GetAll().Where(p => p.DataNascimento.GetValueOrDefault().Day == dia && p.DataNascimento.GetValueOrDefault().Month == mes).ToList();
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
    }
}