using ESalesBussinessLogicLayer;
using ESalesDataEntities.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace ESalesMVC.Controllers
{
    public class CategoryController : Controller
    {
        GenericRepository<Category> catRepo = new GenericRepository<Category>();
        // GET: Category
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Category category = catRepo.GetById(Convert.ToInt32(id));
            if (category == null)
            {
                return HttpNotFound();
            }
            return View(category);
        }
    }
}