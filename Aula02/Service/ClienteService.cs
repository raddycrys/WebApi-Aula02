using Aula02.Model;
using Aula02.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Aula02.Service
{
    public class ClienteService
    {
        public Cliente GetById(int Id)
        {
            var repository = new ClienteRepository();
            return repository.GetByID(Id);
        }

    }
}