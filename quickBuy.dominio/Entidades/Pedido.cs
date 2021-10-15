using quickBuy.dominio.ObjetoDeValor;
using System;
using System.Collections.Generic;
using System.Text;


namespace quickBuy.dominio.Entidades
{
    public class Pedido
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public int UsuarioId { get; set; }
        public DateTime DataPrevisaoEntrega { get; set; }
        public string CEP { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string EnderecoCompleto { get; set; }
        public int NumeroEndereco { get; set; }
        public int FormaPagamento { get; set; }
        public FormaPagamento FormaPagamnto { get; set; }

        /*
          Pedido deve ter pelo menos um item de pedido ou muitos itens de pedidos.
        */
        public ICollection<ItemPedido> ItensPedido { get; set; }

    }
}
