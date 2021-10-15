using quickBuy.dominio.Enumerados;
using System;
using System.Collections.Generic;
using System.Text;

namespace quickBuy.dominio.ObjetoDeValor
{
    public class FormaPagamento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public bool EBoleto {
            get{
                return Id == (int)TipoFormaPagamentoEnum.Boleto;
            }
        }

        public bool ECartaoCredito
        {
            get
            {
                return Id == (int)TipoFormaPagamentoEnum.CartaoCredito;
            }
        }
        public bool EDeposito
        {
            get
            {
                return Id == (int)TipoFormaPagamentoEnum.Deposito;
            }
        }
        public bool NaoFoiDefinido
        {
            get
            {
                return Id == (int)TipoFormaPagamentoEnum.NaoDefinido;
            }
        }
    }
}
