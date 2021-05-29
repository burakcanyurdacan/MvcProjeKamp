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
    public class ContentManager : IContentService
    {
        IContentDAL _contentDal;

        public ContentManager(IContentDAL contentDal)
        {
            _contentDal = contentDal;
        }

        public void AddContent(Content Content)
        {
            throw new NotImplementedException();
        }

        public void DeleteContent(Content Content)
        {
            throw new NotImplementedException();
        }

        public Content GetByContentID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Content> GetContentList()
        {
            throw new NotImplementedException();
        }

        public List<Content> GetContentListById(int id)
        {
            return _contentDal.List(x => x.HeadingId == id);
        }

        public void UpdateContent(Content Content)
        {
            throw new NotImplementedException();
        }
    }
}
