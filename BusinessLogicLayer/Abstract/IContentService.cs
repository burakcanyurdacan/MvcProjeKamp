using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Abstract
{
    public interface IContentService
    {
        List<Content> GetContentList();
        List<Content> GetContentListById(int id);
        void AddContent(Content Content);
        Content GetByContentID(int id);
        void DeleteContent(Content Content);
        void UpdateContent(Content Content);
    }
}
