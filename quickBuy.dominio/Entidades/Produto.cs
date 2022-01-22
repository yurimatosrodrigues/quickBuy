using System;

namespace quickBuy.dominio.Entidades
{
    public class Produto : Entidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public string NomeArquivo { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrEmpty(Nome))
                AdicionarCritica("Nome do produto não foi informado.");
            if (string.IsNullOrEmpty(Descricao))
                AdicionarCritica("Descrição do produto não foi informada.");
            if(Preco <= 0)
                AdicionarCritica("Preço preenchido incorretamente.");

        }
    }
}
