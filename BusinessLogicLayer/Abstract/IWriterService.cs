using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Abstract
{
    public interface IWriterService
    {
        List<Writer> GetWriterList();
        void AddWriter(Writer p);
        void DeleteWriter(Writer p);
        void UpdateWriter(Writer p);
        Writer GetByWriterID(int id);
    }
}
