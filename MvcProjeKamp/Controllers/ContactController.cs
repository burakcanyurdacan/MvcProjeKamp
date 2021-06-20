using BusinessLogicLayer.Concrete;
using BusinessLogicLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKamp.Controllers
{
    public class ContactController : Controller
    {
        ContactManager com = new ContactManager(new EfContactDal());
        ContactValidator cv = new ContactValidator();

        public ActionResult Index()
        {
            var contactVal = com.GetContactList();
            return View(contactVal);
        }

        public ActionResult GetContactDetails(int id)
        {
            var contactVal = com.GetByContactID(id);
            return View(contactVal);
        }

        public PartialViewResult MailMenuPartial()
        {
            return PartialView();
        }
    }
}