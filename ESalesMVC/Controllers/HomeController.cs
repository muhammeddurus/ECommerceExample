using ESalesBussinessLogicLayer;
using ESalesDataAccessLayer.Context;
using ESalesDataEntities.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ESalesMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        GenericRepository<Supplier,Context> catRepo = new GenericRepository<Supplier,Context>();
        public ActionResult Index()
        {
            return View(catRepo.GetAll());
        }
    }
}