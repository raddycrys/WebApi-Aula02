using Aula02.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Aula02.Repository
{
    /// <summary>
    /// Classe Repository de Cliente
    /// </summary>
    public class ClienteRepository
    {
        /// <summary>
        /// Lista que será usada como nosso banco de dados
        /// </summary>
        private static List<Cliente> _listaCliente;

        /// <summary>
        /// Método construtor que irá popular a lista quando instanciado
        /// </summary>
        public ClienteRepository()
        {
            PopularLista();
        }

        /// <summary>
        /// Método responsável por popular a lista 
        /// </summary>
        /// <returns></returns>
        private List<Cliente> PopularLista()
        {
            if (_listaCliente == null)
            {
                _listaCliente = new List<Cliente>
                {
                    new Cliente() { Ativo = true, Id = 1, Nome = "Caroline", Sexo = TipoSexo.Feminino, DataNascimento = new DateTime(1994, 2, 5) },
                    new Cliente() { Ativo = false, Id = 2, Nome = "Cris", Sexo = TipoSexo.Feminino, DataNascimento = new DateTime(1981, 9, 24) },
                    new Cliente() { Ativo = false, Id = 3, Nome = "Togashi", Sexo = TipoSexo.Masculino, DataNascimento = null },
                    new Cliente() { Ativo = true, Id = 4, Nome = "Thiago", Sexo = TipoSexo.Masculino, DataNascimento = null },
                    new Cliente() { Ativo = true, Id = 5, Nome = "Aline", Sexo = TipoSexo.Feminino, DataNascimento = null }
                };
            }

            return _listaCliente;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Cliente GetByID(int id)
        {
            return _listaCliente.Where(p => p.Id == id).FirstOrDefault();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Cliente> GetAll()
        {
            return _listaCliente;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        public void Delete(int id)
        {
            var clienteAux = GetByID(id);

            if (clienteAux != null)
                _listaCliente.Remove(clienteAux);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cliente"></param>
        public void Update(Cliente cliente)
        {
            var clienteAux = GetByID(cliente.Id);

            if (clienteAux != null)
            {
                _listaCliente.Remove(clienteAux);

                _listaCliente.Add(cliente);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="ativar"></param>
        public void AtivaOrInativa(int id, bool ativar)
        {
            var clienteAux = GetByID(id);

            if (clienteAux != null)
                clienteAux.Ativo = ativar;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cliente"></param>
        public void Insert(Cliente cliente)
        {
            _listaCliente.Add(cliente);
        }
    }
}