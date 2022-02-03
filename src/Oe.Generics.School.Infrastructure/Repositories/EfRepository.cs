using Oe.Generics.School.Core.Entities;
using Oe.Generics.School.Core.Infrastructure;
using Oe.Generics.School.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Oe.Generics.School.Infrastructure.Repositories
{
    public class EfRepository<T> : IEfRepository<T> where T : BaseEntity
    {
        protected readonly ApplicationDbContext _dbContext;

        public EfRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Delete(T entity)
        {
            _dbContext.Set<T>().Remove(entity);
            _dbContext.SaveChanges();
        }

        public virtual T GetById(Guid id)
        {
            return _dbContext.Set<T>().SingleOrDefault(t => t.Id.Equals(id));
        }

        public virtual IList<T> ListAll()
        {
            return _dbContext.Set<T>().ToList();
        }

        public void Update(T entity)
        {
            _dbContext.Set<T>().Update(entity);
            _dbContext.SaveChanges();
        }
    }
}
