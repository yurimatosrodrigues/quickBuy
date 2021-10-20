using System;
using System.Collections.Generic;

namespace quickBuy.dominio.Entidades
{
    public class ItemPedido : Entidade
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }

        public override void Validate()
        {
            if (ProdutoId == 0)
                AdicionarCritica("Crítica: Não foi identificada a referência do produto.");
            if (Quantidade == 0)
                AdicionarCritica("Crítica: Quantidade não informada.");
        }
    }
}
