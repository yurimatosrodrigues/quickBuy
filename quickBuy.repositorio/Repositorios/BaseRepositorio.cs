using quickBuy.dominio.Contratos;
using quickBuy.repositorio.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;

namespace quickBuy.repositorio.Repositorios
{
    public class BaseRepositorio<TEntity> : IBaseRepositorio<TEntity> where TEntity : class
    {
        protected readonly QuickBuyContexto QuickBuyContexto;

        // O context recebe a instância automaticamente por causa do método "services.AddDbContext" da classe startup
        public BaseRepositorio(QuickBuyContexto quickBuyContexto) {
            QuickBuyContexto = quickBuyContexto;
        }

        public void Adicionar(TEntity entity)
        {
            QuickBuyContexto.Set<TEntity>().Add(entity);
            QuickBuyContexto.SaveChanges();
        }

        public void Atualizar(TEntity entity)
        {
            QuickBuyContexto.Set<TEntity>().Update(entity);
            QuickBuyContexto.SaveChanges();
        }       

        public TEntity ObterPorId(int id)
        {
            return QuickBuyContexto.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> ObterTodos()
        {
            return QuickBuyContexto.Set<TEntity>().ToList();
        }

        public void Remover(TEntity entity)
        {
            QuickBuyContexto.Remove(entity);
            QuickBuyContexto.SaveChanges();
        }
        public void Dispose()
        {
            QuickBuyContexto.Dispose();
        }
    }
}
