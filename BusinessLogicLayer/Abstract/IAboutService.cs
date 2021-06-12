using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Abstract
{
    public interface IAboutService
    {
        List<About> GetAboutList();
        void AddAbout(About about);
        About GetByAboutID(int id);
        void DeleteAbout(About about);
        void UpdateAbout(About about);
    }
}
