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
    public class ImageFileManager : IImageFileService
    {
        IImageFileDAL _imageFileDal;

        public ImageFileManager(IImageFileDAL imageFileDal)
        {
            _imageFileDal = imageFileDal;
        }

        public List<ImageFile> GetList()
        {
           return _imageFileDal.List();
        }
    }
}
