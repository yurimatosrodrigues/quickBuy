﻿using System.Collections.Generic;

namespace quickBuy.dominio.Entidades
{
    public class ItemPedido
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }        
    }
}
