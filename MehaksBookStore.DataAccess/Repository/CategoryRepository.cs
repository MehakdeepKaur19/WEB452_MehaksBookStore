using MehaksBooks.DataAccess.Repository.IRepository;
using MehaksBooks.Models;
using MehaksBookStore.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MehaksBooks.DataAccess.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly ApplicationDbContext _db;
        public CategoryRepository(ApplicationDbContext db) : base(db) //use hot keys C-T-O-R to build the constructor
        {
            _db = db;
        }

        public void Update(Category category)
        {
            //use .NET LINQ to retrieve the first or default category object,
            //then pass the idas a generic entity which matches the category ID
            var objFromDb = _db.Categories.FirstOrDefault(s => s.Id == category.Id);
            if (objFromDb != null) //save changes if not null
            {
                objFromDb.Name = category.Name;
            }
        }
    }
}
