using Aula02.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Aula02.Repository
{
    public class ClienteRepository
    {
        private static List<Cliente> ListaCliente;

        public ClienteRepository()
        {
            PopularLista();
        }

        private List<Cliente> PopularLista()
        {
            //var lista = new List<Cliente>();

            ListaCliente.Add(new Cliente() { Ativo = true, ID = 1, Nome = "Caroline", Sexo = "F", DataNasc = null });
            ListaCliente.Add(new Cliente() { Ativo = false, ID = 2, Nome = "Cris", Sexo = "F", DataNasc = new DateTime(1994,2,5) });
            ListaCliente.Add(new Cliente() { Ativo = false, ID = 3, Nome = "Togashi", Sexo = "M", DataNasc = null });
            ListaCliente.Add(new Cliente() { Ativo = true, ID = 4, Nome = "Thiago", Sexo = "M", DataNasc = null });
            ListaCliente.Add(new Cliente() { Ativo = true, ID = 5, Nome = "Aline", Sexo = "F", DataNasc = null });

            return ListaCliente;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Cliente GetByID(int id)
        {
            return ListaCliente.Where(p => p.ID == id).FirstOrDefault();
        }

        public void Delete(int Id)
        {
            var cliente = GetByID(Id);

            if (cliente != null)
                ListaCliente.Remove(cliente);
        }

        public void Update(Cliente cliente)
        {
            ListaCliente.Remove(cliente);

            ListaCliente.Add(cliente);
        }

        public void Create(Cliente cliente)
        {
            ListaCliente.Add(cliente);
        }
    }
}