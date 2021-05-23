using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Abstract
{
    public interface IHeadingService
    {
        List<Heading> GetHeadingList();
        void AddHeading(Heading p);
        void DeleteHeading(Heading p);
        void UpdateHeading(Heading p);
        Heading GetByHeadingID(int id);
    }
}
