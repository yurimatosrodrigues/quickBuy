using quickBuy.dominio.Contratos;
using quickBuy.dominio.Entidades;
using quickBuy.repositorio.Contexto;
using System;
using System.Collections.Generic;
using System.Text;

namespace quickBuy.repositorio.Repositorios
{
    public class UsuarioRepositorio : BaseRepositorio<Usuario>, IUsuarioRepositorio
    {
        public UsuarioRepositorio(QuickBuyContexto quickBuyContexto) : base(quickBuyContexto)
        {
        }
    }
}
