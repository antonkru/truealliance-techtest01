using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace TechTest01.Domain
{
    public interface IRepository<TEntity> where TEntity : BaseEntity
    {
        IQueryable<TEntity> GetAll();
        IQueryable<TEntity> Query(Expression<Func<TEntity, bool>> query);

        TEntity Get(int id);
        void Insert(TEntity model);
        void Update(TEntity model);
        void Delete(int id);
        int SaveChanges();

    }
}

