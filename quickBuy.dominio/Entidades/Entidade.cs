using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace quickBuy.dominio.Entidades
{
    public abstract class Entidade
    {
        public List<string> _mensagensValidacao { get; set; }
        private List<string> mensagemValidacao { 
            get { 
                return _mensagensValidacao ?? (_mensagensValidacao = new List<string>()); 
            }
        }

        protected void AdicionarCritica(string mensagem)
        {
            mensagemValidacao.Add(mensagem);
        }

        protected void LimparMensagensValidacao() {
            mensagemValidacao.Clear();
        }

        //Abstract obriga a implementação nas classes filhas.
        public abstract void Validate();
        protected bool EValido {
            get {
                return !mensagemValidacao.Any();
            }
        }

    }
}
