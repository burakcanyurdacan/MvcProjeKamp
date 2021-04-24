using DataAccessLayer.Contrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Concrete
{
    public class CategoryManager
    {
        GenericRepository<Category> repo = new GenericRepository<Category>();
        public List<Category> GetAll()
        {
            return repo.List();
        }

        public void AddCategory(Category p)
        {
            if (p.CategoryName == "" || p.CategoryName.Length <= 3 || p.CategoryDesc == "" || p.CategoryName.Length >= 51)
            {
                //Hata mesajı döndür
            }
            else
            {
                repo.Insert(p);
            }
        }
    }
}
