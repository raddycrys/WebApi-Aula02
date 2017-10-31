using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Aula02.Model
{
    public class Cliente
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public DateTime? DataNasc { get; set; }
        public string Sexo { get; set; }
        public bool Ativo { get; set; }
    }
}