using Aula02.Model.Base;
using System;
using System.Collections.Generic;

namespace Aula02.Model
{
    public class Pedido : BaseEntity
    {
        public Pedido()
        {
            Itens = new List<ItemPedido>();
        }

        public DateTime DataEmissao { get; set; }
        public decimal Total { get; set; }
        public Cliente Cliente { get; set; }
        public List<ItemPedido> Itens { get; set; }
    }

    public class ItemPedido : BaseEntity
    {
        public Produto Produto { get; set; }
        public int Quantidade { get; set; }
        public decimal Valor { get; set; }
    }
}