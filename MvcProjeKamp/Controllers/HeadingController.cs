using BusinessLogicLayer.Concrete;
using DataAccessLayer.Contrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKamp.Controllers
{
    public class HeadingController : Controller
    {
        HeadingManager hm = new HeadingManager(new EfHeadingDal());
        CategoryManager cm = new CategoryManager(new EfCategoryDal());
        WriterManager wm = new WriterManager(new EfWriterDal());
        public ActionResult Index()
        { 
            var headingValues = hm.GetHeadingList();
            return View(headingValues);
        }

        public ActionResult AddHeading()
        {
            List<SelectListItem> categoryListItem = (from x in cm.GetCategoryList()
                                                     select new SelectListItem
                                                     {
                                                         Text = x.CategoryName,
                                                         Value = x.CategoryId.ToString()
                                                     }).ToList();

            List<SelectListItem> writerListItem = (from y in wm.GetWriterList()
                                                   select new SelectListItem 
                                                   {
                                                       Text = y.WriterName+" "+y.WriterSurname,
                                                       Value = y.ID.ToString()
                                                   }).ToList();

            ViewBag.clv = new SelectList(cm.GetCategoryList(), "CategoryId", "CategoryName");
            ViewBag.wrv = writerListItem;
            //ViewBag.clv = categoryListItem;
            return View();
        }

        [HttpPost]
        public ActionResult AddHeading(Heading p)
        {
            p.AddingDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            hm.AddHeading(p);
            return RedirectToAction("Index");
        }

        public ActionResult EditHeading(int id)
        {
            ViewBag.testlist = new SelectList(cm.GetCategoryList(), "CategoryId", "CategoryName");
            var value = hm.GetByHeadingID(id);
            return View(value);
        }
    }
}