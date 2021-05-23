using BusinessLogicLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Contrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDAL _categoryDal;

        public CategoryManager(ICategoryDAL categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void AddCategory(Category category)
        {
            _categoryDal.Insert(category);
        }

        public void UpdateCategory(Category category)
        {
            _categoryDal.Update(category);
        }

        public Category GetByCategoryID(int id)
        {
            return _categoryDal.GetByID(x => x.CategoryId == id);
        }

        public List<Category> GetCategoryList()
        {
            return _categoryDal.List();
        }

        public void DeleteCategory(Category category)
        {
            _categoryDal.Delete(category);
        }
    }
}
