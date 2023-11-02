using MehaksBooks.DataAccess.Repository.IRepository;
using MehaksBookStore.DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace MehaksBooks.DataAccess.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        //modify the database with the db context
        private readonly ApplicationDbContext _db; //get the db instance using the constructor and DI
        internal DbSet<T> dbSet;
        public Repository(ApplicationDbContext db) //use hot keys C-T-O-R to build the constructor
        {
            _db = db;
            this.dbSet = _db.Set<T>();
        }
        public void Add(T entity)
        {
            throw new NotImplementedException();
        }

        public T Get(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IQueryable<T>> orderBy = null, string includeProperties = null)
        {
            throw new NotImplementedException();
        }

        public T GetFirstOrDefault(Expression<Func<T, bool>> filter = null, string includeProperties = null)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(T entity)
        {
            throw new NotImplementedException();
        }

        public void RemoveRange(IEnumerable<T> entity)
        {
            throw new NotImplementedException();
        }
    }
}
