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
    public class MessageManager : IMessageService
    {
        IMessageDAL _messageDal;

        public MessageManager(IMessageDAL messageDal)
        {
            _messageDal = messageDal;
        }

        public void AddMessage(Message msg)
        {
            _messageDal.Insert(msg);
        }

        public void DeleteMessage(Message msg)
        {
            throw new NotImplementedException();
        }

        public Message GetByMessageID(int id)
        {
            return _messageDal.GetByID(x => x.MessageId == id);
        }

        public List<Message> GetListInbox()
        {
            return _messageDal.List(x => x.ReceiverMail == "admin@gmail.com");
        }

        public List<Message> GetListSendbox()
        {
            return _messageDal.List(x => x.SenderMail == "admin@gmail.com");
        }

        public void UpdateMessage(Message msg)
        {
            _messageDal.Update(msg);
        }
    }
}
