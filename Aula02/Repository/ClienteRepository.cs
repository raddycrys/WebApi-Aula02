﻿using Aula02.Model;
using Aula02.Repository.Base;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Aula02.Repository
{
    /// <summary>
    /// Classe Repository de Cliente
    /// </summary>
    public sealed class ClienteRepository : BaseRepository<Cliente>
    {

        /// <summary>
        /// Método responsável por popular a lista 
        /// </summary>
        /// <returns></returns>
        protected override List<Cliente> PopularLista()
        {

            _lista = new List<Cliente>
            {
                new Cliente() { Ativo = true, Id = 1, Nome = "Caroline", Sexo = TipoSexo.Feminino, DataNascimento = new DateTime(1994, 2, 5) },
                new Cliente() { Ativo = false, Id = 2, Nome = "Cris", Sexo = TipoSexo.Feminino, DataNascimento = new DateTime(1981, 9, 24) },
                new Cliente() { Ativo = false, Id = 3, Nome = "Togashi", Sexo = TipoSexo.Masculino, DataNascimento = null },
                new Cliente() { Ativo = true, Id = 4, Nome = "Thiago", Sexo = TipoSexo.Masculino, DataNascimento = null },
                new Cliente() { Ativo = true, Id = 5, Nome = "Aline", Sexo = TipoSexo.Feminino, DataNascimento = null }
            };

            return _lista;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="ativar"></param>
        public void AtivaOrInativa(int id, bool ativar)
        {
            var clienteAux = GetById(id);

            if (clienteAux != null)
                clienteAux.Ativo = ativar;
        }
    }
}