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
    public class WriterManager : IWriterService
    {
        IWriterDAL _writerDal;

        public WriterManager(IWriterDAL writerDal)
        {
            _writerDal = writerDal;
        }

        public void AddWriter(Writer p)
        {
            _writerDal.Insert(p);
        }

        public void DeleteWriter(Writer p)
        {
            _writerDal.Delete(p);
        }

        public Writer GetByWriterID(int id)
        {
            return _writerDal.GetByID(x => x.ID == id);
        }

        public List<Writer> GetWriterList()
        {
            return _writerDal.List();
        }

        public void UpdateWriter(Writer p)
        {
            _writerDal.Update(p);
        }
    }
}
