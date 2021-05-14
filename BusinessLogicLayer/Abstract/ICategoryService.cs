using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetList();
        void AddCategory(Category category);
        Category GetByID(int id);
    }
}
