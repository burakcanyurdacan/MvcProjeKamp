using BusinessLogicLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace BusinessLogicLayer.Concrete
{
    public class HeadingManager : IHeadingService
    {
        IHeadingDAL _headingDal;

        public HeadingManager(IHeadingDAL headingDal)
        {
            _headingDal = headingDal;
        }

        public void AddHeading(Heading p)
        {
            _headingDal.Insert(p);
        }

        public void DeleteHeading(Heading p)
        {
            //if (p.HeadingStatus == true)
            //{
            //    p.HeadingStatus = false;
            //}
            //else
            //{
            //    p.HeadingStatus = true;
            //}
            _headingDal.Update(p);
        }

        public Heading GetByHeadingID(int id)
        {
            return _headingDal.GetByID(x => x.ID == id);
        }

        public List<Heading> GetHeadingList()
        {
            return _headingDal.List();
        }

        public List<Heading> GetHeadingListByWriter(int id)
        {
            return _headingDal.List(x => x.WriterId == id);
        }

        public void UpdateHeading(Heading p)
        {
            _headingDal.Update(p);
        }
    }
}
