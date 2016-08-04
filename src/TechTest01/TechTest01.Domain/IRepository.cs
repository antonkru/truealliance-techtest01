using System.Collections.Generic;
using System.Linq;


namespace TechTest01.Domain
{
    public interface IRepository<TEntity> where TEntity : BaseEntity
    {
        IQueryable<TEntity> GetAll();
        TEntity Get(int id);
        TEntity Get(string slug);
        void Insert(TEntity model);
        void Update(TEntity model);
        void Delete(int id);
        int SaveChanges();

    }
}

