
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAcces.EntityFramework
{
    //A base clas was created for the Entity Framework, making all CRUD operations manageable in one place
    public class EFEntityRepositoryBase<EntityTip, ContextTip> : IEntityRepository<EntityTip>
    where EntityTip : class, IEntity, new()//For the Entity type, a requirement was introduced to enter a class that can only be newlened and holds the IEntity reference
    where ContextTip : DbContext, new()//For the Contex type, only the requirement for entering an object that comes from Dbcontex and can be new was written.
    {
        //All CRUD Operation made in here
        public void Add(EntityTip entity)
        {
            //IDisposable pattern implementation of C# 
            using (ContextTip context = new ContextTip())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(EntityTip entity)
        {
            using (ContextTip context = new ContextTip())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public EntityTip Get(Expression<Func<EntityTip, bool>> filter)
        {
            using (ContextTip context = new ContextTip())
            {
                return context.Set<EntityTip>().SingleOrDefault(filter);
            }
        }

        public List<EntityTip> GetAll(Expression<Func<EntityTip, bool>> filter = null)
        {
            using (ContextTip context = new ContextTip())
            {
                if (filter == null)
                {
                    return context.Set<EntityTip>().ToList();
                }
                else
                {
                    return context.Set<EntityTip>().Where(filter).ToList();
                }
            }
        }

        public void Update(EntityTip entity)
        {
            using (ContextTip context = new ContextTip())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
