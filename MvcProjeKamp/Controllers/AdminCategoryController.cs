using BusinessLogicLayer.Concrete;
using BusinessLogicLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKamp.Controllers
{
    public class AdminCategoryController : Controller
    {
        CategoryManager cm = new CategoryManager(new EfCategoryDal());

        [Authorize]
        public ActionResult Index()
        {
            var categoryValues = cm.GetCategoryList();
            return View(categoryValues);
        }

        [HttpGet]
        public ActionResult AddCategory()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddCategory(Category p)
        {
            CategoryValidator validations = new CategoryValidator();
            ValidationResult result = validations.Validate(p);
            if (result.IsValid)
            {
                cm.AddCategory(p);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (ValidationFailure item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }

        public ActionResult DeleteCategory(int id)
        {
            var categoryVal = cm.GetByCategoryID(id);
            cm.DeleteCategory(categoryVal);
            return RedirectToAction("Index");
        }

        public ActionResult UpdateCategory(int id)
        {
            var category = cm.GetByCategoryID(id);
            return View(category);
        }

        [HttpPost]
        public ActionResult UpdateCategory(Category p)
        {
            cm.UpdateCategory(p);
            return RedirectToAction("Index");
        }
    }
}