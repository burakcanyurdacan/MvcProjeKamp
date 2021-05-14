using BusinessLogicLayer.Concrete;
using DataAccessLayer.Contrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKamp.Controllers
{
    public class StatisticsController : Controller
    {
        Context cm = new Context();
        // GET: Statistics
        public ActionResult Statistics()
        {
            //1) Toplam kategori sayısı
            ViewBag.ToplamKategoriSayisi = cm.Categories.Count();

            //2) Yazılım kategorisine ait başlık sayısı
            ViewBag.YazilimBaslik = cm.Headings.Count(x => x.CategoryId == 10);

            //3) Yazar adında "a" harfi olan yazar sayısı
            ViewBag.YazarSayisi = cm.Writers.Count(x => x.WriterName.Contains("a"));

            //4) En fazla başlığa sahip kategori
            ViewBag.MaksimumBaslik = cm.Categories.Where(x => x.CategoryId == cm.Headings.GroupBy(y => y.CategoryId).OrderByDescending(y => y.Count()).Select(y => y.Key).FirstOrDefault()).Select(z => z.CategoryName).FirstOrDefault();

            //5) Aktif ve pasif kategori arasındaki sayısal fark
            ViewBag.AktifKategoriler = cm.Categories.Count(x => x.CategoryStatus == true);
            ViewBag.PasifKategoriler = cm.Categories.Count(x => x.CategoryStatus == false);

            return View();
        }
    }
}