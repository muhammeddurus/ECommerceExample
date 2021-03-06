using ESalesBussinessLogicLayer;
using ESalesDataAccessLayer.Context;
using ESalesDataEntities.Model;
using ESalesMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace ESalesMVC.Controllers
{
    public class ProductController : Controller
    {
        GenericRepository<Product,Context> proRepo = new GenericRepository<Product, Context>();
        GenericRepository<Supplier, Context> supRepo = new GenericRepository<Supplier, Context>();
        GenericRepository<Category, Context> catRepo = new GenericRepository<Category, Context>();
        // GET: Product
        public ActionResult Index()
        {
            return View(proRepo.GetAll());
        }

        [HttpGet]
        public ActionResult Create()
        {
            List<SelectListItem> deger1 = (from s in supRepo.GetAll()
                                           select new SelectListItem
                                           {
                                               Text = s.CompanyName,
                                               Value = s.ID.ToString()
                                           }).ToList();

            List<SelectListItem> deger2 = (from c in catRepo.GetAll()
                                           select new SelectListItem
                                           {
                                               Text = c.Name,
                                               Value = c.ID.ToString()
                                           }).ToList();

            ViewBag.dgr1 = deger1;
            ViewBag.dgr2 = deger2;

            return View();
        }

        [HttpPost]
        public ActionResult Create(Product product)
        {
            if (!ModelState.IsValid)
            {
                List<SelectListItem> deger1 = (from s in supRepo.GetAll()
                                               select new SelectListItem
                                               {
                                                   Text = s.CompanyName,
                                                   Value = s.ID.ToString()
                                               }).ToList();

                List<SelectListItem> deger2 = (from c in catRepo.GetAll()
                                               select new SelectListItem
                                               {
                                                   Text = c.Name,
                                                   Value = c.ID.ToString()
                                               }).ToList();

                ViewBag.dgr1 = deger1;
                ViewBag.dgr2 = deger2;
                return View("Create");
            }



            //var supplier = supRepo.GetById(Convert.ToInt32(product.Supplier.ID));
            //var category = catRepo.GetById(Convert.ToInt32(product.Category_ID));

            //product.Category = category;
            //product.Supplier = supplier;

            proRepo.Insert(product);


            return RedirectToAction("Index");
        }
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = proRepo.GetById(Convert.ToInt32(id));
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        [HttpPost]
        public ActionResult Details(int id)
        {
            Product product = proRepo.GetById(id);
            AddToCartProduct.Products.Add(product);

               
            return RedirectToAction("Index");
        }
    }
}