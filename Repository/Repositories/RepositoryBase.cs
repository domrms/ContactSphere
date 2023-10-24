using Core.Interface.Repository;
using Data;
using Microsoft.EntityFrameworkCore;

namespace Repository.Repositories
{
    public abstract class RepositoryBase<TEntity> : IDisposable, IRepositoryBase<TEntity> where TEntity : class
    {
        private readonly DataContext _context;

        public RepositoryBase(DataContext context)
        {
            _context = context;
            _context.Database.SetCommandTimeout(0);
        }

        public void Add(TEntity obj)
        {
            try
            {
                _context.Entry(obj).State = EntityState.Added;
                _context.Set<TEntity>().Add(obj);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Update(TEntity obj)
        {
            try
            {
                _context.Entry(obj).State = EntityState.Modified;
                _context.Set<TEntity>().Update(obj);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
