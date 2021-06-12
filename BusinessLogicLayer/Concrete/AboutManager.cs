using BusinessLogicLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Concrete
{
    public class AboutManager : IAboutService
    {
        IAboutDAL _aboutDal;

        public AboutManager(IAboutDAL aboutDal)
        {
            _aboutDal = aboutDal;
        }

        public void AddAbout(About about)
        {
            _aboutDal.Insert(about);
        }

        public void DeleteAbout(About about)
        {
            _aboutDal.Delete(about);
        }

        public List<About> GetAboutList()
        {
            return _aboutDal.List();
        }

        public About GetByAboutID(int id)
        {
            return _aboutDal.GetByID(x => x.AboutId == id);
        }

        public void UpdateAbout(About about)
        {
            _aboutDal.Update(about);
        }
    }
}
