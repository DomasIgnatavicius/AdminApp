using AdminApp.Data;
using AdminApp.Repositories.IRepositories;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace AdminApp.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly ShopContext _db;
        private DbSet<TEntity> _dbset;

        public Repository(ShopContext db)
        {
            _db = db;
            _dbset = _db.Set<TEntity>();
        }

        public void Create(TEntity entity)
        {
            _dbset.Add(entity); // lentele, idek nauja irasa
            Save();
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter, bool tracked = true)
        {
            IQueryable<TEntity> query = _dbset; // select * from TEntity 

            if (!tracked)
            {
                query = query.AsNoTracking();
            }
            query.Where(filter);
            return query.FirstOrDefault();
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>>? filter = null)
        {
            IQueryable<TEntity> query = _dbset;
            if (filter != null)
            {
                query.Where(filter);
            }
            return query.ToList();
        }

        public void Remove(TEntity entity)
        {
            _dbset.Remove(entity);
            Save();
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
