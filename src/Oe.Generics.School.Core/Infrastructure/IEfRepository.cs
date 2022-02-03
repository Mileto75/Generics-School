using Oe.Generics.School.Core.Entities;
using System;
using System.Collections.Generic;

namespace Oe.Generics.School.Core.Infrastructure
{
    public interface IEfRepository<T> where T : BaseEntity
    {
        IList<T> ListAll();
        T GetById(Guid id);
        void Delete(T entity);
        void Update(T entity);
    }
}
