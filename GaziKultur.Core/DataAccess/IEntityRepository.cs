using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using GaziKultur.Core.Entities;

namespace GaziKultur.Core.DataAccess
{
    // Generic repository sözleşmesi. Her entity (Kutuphane, Muze, ileride eklenecek her şey)
    // bu arayüz sayesinde aynı CRUD metotlarına sahip olur, kod tekrarı olmaz.
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        T Get(Expression<Func<T, bool>> filter);
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
