using MehaksBooks.DataAccess.Repository.IRepository;
using MehaksBookStore.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace MehaksBooks.DataAccess.Repository
{
    public class UnitOfWork //make themethod public to access the class
    {
        private readonly ApplicationDbContext _db; //the using statement
        public UnitOfWork(ApplicationDbContext db) //constructor to use DI and inject in the repositories
        {
            _db = db;
            Category = new CategoryRepository(_db);
            SP_Call = new SP_Call(_db);
        }

        public ICategoryRepository Category { get; private set; }
        public ISP_Call SP_Call { get; private set; }
        public void Dispose()
        {
            _db.Dispose();
        }
        public void Save() // all changes will be saved when the Save method is called at the 'parent' level
        {
            _db.SaveChanges();
        }
    }
}
