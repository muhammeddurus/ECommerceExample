using ESalesBussinessLogicLayer;
using ESalesDataAccessLayer.Context;
using ESalesDataEntities.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace ESalesMVC.Controllers
{
    public class SupplierController : Controller
    {
        GenericRepository<Supplier, Context> supRepo = new GenericRepository<Supplier, Context>();
        // GET: Supplier
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
                Supplier supplier = supRepo.GetById(Convert.ToInt32(id));
                if (supplier == null)
                {
                    return HttpNotFound();
                }
                return View(supplier);
            
        }
    }
}