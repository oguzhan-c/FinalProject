
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAcces.EntityFramework
{
    //generic Constraint
    //class :referans tip
    //IEntity veya onu implemente eden bir nesne
    //new() :new lenebillen bir obje
    public interface IEntityRepository<Tip> where Tip : class, IEntity, new()
    {
        List<Tip> GetAll(Expression<Func<Tip, bool>> filter = null);
        Tip Get(Expression<Func<Tip, bool>> filter);
        void Add(Tip entity);
        void Update(Tip entity);
        void Delete(Tip entity);
    }
}
