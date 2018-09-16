using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BeachCabinReservation.Data.Repositories
{
    public abstract class RepositoryBase<T> where T : class
    {
        protected AppDataContext context;

        public RepositoryBase(AppDataContext context)
        {
            this.context = context;
        }

        public virtual IQueryable<T> Get()
        {
            return context.Set<T>();
        }

        public virtual void Insert(T obj)
        {
            context.Add(obj);
        }

        public virtual void Update(T newValues)
        {
            context.Set<T>().Attach(newValues);
            context.Entry(newValues).State = EntityState.Modified;
        }

        public virtual void Delete(int id)
        {
            var obj = context.Set<T>().Find(id);
            if (obj != null)
                context.Set<T>().Remove(obj);
        }
    }
}
