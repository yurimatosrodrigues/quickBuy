using quickBuy.dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace quickBuy.dominio.Contratos
{
    public interface IUsuarioRepositorio : IBaseRepositorio<Usuario>
    {
        Usuario Obter(string email, string senha);
    }
}
