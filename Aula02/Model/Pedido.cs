using Aula02.Model.Base;
using System;

namespace Aula02.Model
{
    public class Pedido : BaseEntity
    {
        public DateTime DataEmissao { get; set; }
        public decimal Total { get; set; }
    }
}