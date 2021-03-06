﻿using MicCheck.Data.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using MicCheck.Data;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MicCheck.Data.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private ApplicationDbContext _dbContext;
        DbSet<T> _dbSet;
        public Repository(ApplicationDbContext context)
        {
            _dbContext = context;
            _dbSet = _dbContext.Set<T>();
        }

        //public IQueryable<T> Find(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includes)
        //{
        //    var query = _dbSet.Where(predicate).AsQueryable();
        //    if (includes != null)
        //    {
        //        query = includes.Aggregate(query, (current, include) => current.Include(include));
        //    }
        //    return query;
        //}

        public int Count()
        {
            return _dbSet.Count();
        }

        public void Delete(T entity)
        {
            _dbSet.Remove(entity);
            _dbContext.SaveChanges();
        }

        public T Get(Expression<Func<T, bool>> predicate = null)
        {
            return _dbSet.FirstOrDefault(predicate);
        }

        public List<T> GetAll(Expression<Func<T, bool>> predicate = null)
        {
            return _dbSet.Where(predicate).ToList();
        }

        public void Insert(T entity)
        {
            _dbSet.Add(entity);
            _dbContext.SaveChanges();
        }

        public void Update(T entity)
        {
            if (entity == null)
                throw new ArgumentException("Entity is needed for an update!");

            _dbContext.Update(entity);
            _dbContext.SaveChanges();
        }
    }
}
