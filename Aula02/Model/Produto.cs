using Aula02.Model.Base;
using System;

namespace Aula02.Model
{
    public class Produto : BaseEntity
    {
        public string Descricao { get; set; }
        public Decimal Valor { get; set; }
        public int Quantidade { get; set; }
        public int EstoqueMinimo { get; set; }
    }
}