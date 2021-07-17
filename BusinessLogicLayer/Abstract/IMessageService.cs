using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Abstract
{
    public interface IMessageService
    {
        List<Message> GetListInbox();
        List<Message> GetListSendbox();
        void AddMessage(Message Message);
        Message GetByMessageID(int id);
        void DeleteMessage(Message Message);
        void UpdateMessage(Message Message);
    }
}
