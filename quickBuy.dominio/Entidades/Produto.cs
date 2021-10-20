using System;
using System.Collections.Generic;
using System.Text;

namespace quickBuy.dominio.Entidades
{
    public class Produto : Entidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }

        public override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
