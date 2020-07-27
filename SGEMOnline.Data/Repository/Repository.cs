using Microsoft.EntityFrameworkCore;
using SGEMOnline.Business.Interfaces;
using SGEMOnline.Business.Models;
using SGEMOnline.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SGEMOnline.Data.Repository
{
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity, new()
    {
        protected readonly SGEMOnlineDBContext DBContext;
        protected readonly DbSet<TEntity> DbSet;

        public Repository(SGEMOnlineDBContext dBContext)
        {
            DBContext = dBContext;
            DbSet = dBContext.Set<TEntity>();
        }

        public virtual async Task Adicionar(TEntity entity)
        {
            DbSet.Add(entity);
            await SaveChanges();
        }

        public virtual async Task Atualizar(TEntity entity)
        {
            DbSet.Update(entity);
            await SaveChanges();
        }

        public virtual async Task<IEnumerable<TEntity>> Buscar(Expression<Func<TEntity, bool>> predicate)
        {
            return await DbSet.AsNoTracking().Where(predicate).ToListAsync();
        }        

        public virtual async Task<TEntity> ObterPorCodigo(Guid codigo)
        {
            return await DbSet.FindAsync(codigo);
        }

        public virtual async Task<List<TEntity>> ObterTodos()
        {
            return await DbSet.ToListAsync();
        }

        public virtual async Task Remover(Guid codigo)
        {
            DbSet.Remove(new TEntity { Codigo = codigo });
            await SaveChanges();
        }

        public virtual async Task<int> SaveChanges()
        {
            return await DBContext.SaveChangesAsync();
        }


        public void Dispose()
        {
            DBContext?.Dispose();
        }

        
    }
}
