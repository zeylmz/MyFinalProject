using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    //generic constraint
    //class : referans tip olabilir
    //IEntity olabilir veya IEntity implemente edilmiş bir nesne olabilir.
    //new(): new'lenebilir olmalı
    public interface IEntitiyRepository<T> where T : class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter = null); //Filtre vermeyedebilirsin demek null
        T Get(Expression<Func<T, bool>> filter); // Filtre gerekli demek
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
