﻿using Data.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Concrete
{
    public class EfCoreGenericRepository<TEntity, TContext> : IRepository<TEntity> where TEntity : class where TContext : DbContext, new()
    {
        public void Add(TEntity entity)
        {
           using (var context = new TContext())
            {
                context.Set<TEntity>().Add(entity);
                context.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
           using(var context = new TContext())
            {
                context.Set<TEntity>().Remove(entity);
                context.SaveChanges();
            }
        }

        public TEntity Get(int id)
        {
            using (var context = new TContext())
            {
              return context.Set<TEntity>().Find(id);
               
            }
        }

        public List<TEntity> GetAll()
        {
           using( var context = new TContext())
            {
              return  context.Set<TEntity>().ToList();
            }
        }

        public void Update(TEntity entity)
        {
           using(var context= new TContext())
            {
                context.Set<TEntity>().Update(entity);
                context.SaveChanges();
            }
        }
    }
}
