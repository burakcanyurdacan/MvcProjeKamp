using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Contrete.Repositories
{
    public class CategoryRepository : ICategoryDAL
    {
        Context ct = new Context();
        DbSet<Category> _object;

        public void Delete(Category c)
        {
            _object.Remove(c);
            ct.SaveChanges();
        }

        public Category GetByID(Expression<Func<Category, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Insert(Category c)
        {
            _object.Add(c);
            ct.SaveChanges();
            
        }

        public List<Category> List()
        {
            return _object.ToList();
        }

        public List<Category> List(Expression<Func<Category, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Update(Category c)
        {
            ct.SaveChanges();
        }
    }
}