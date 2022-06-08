using ESalesBussinessLogicLayer;
using ESalesDataAccessLayer.Context;
using ESalesDataEntities.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace ESalesMVC.Controllers
{
    public class LoginController : Controller
    {
        Context db = new Context();
        GenericRepository<Customer,Context> cusRepo = new GenericRepository<Customer,Context>();
        // GET: Login
        [HttpGet]
        [AllowAnonymous]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult Index(string email,string password)
        {
            
            if (cusRepo.GetAll().Where(x => x.Email == email && x.Password == password) != null)
            {
                Customer customer2 = new Customer();
                foreach (var item in cusRepo.GetAll())
                {
                    if (item.Email == "muhammeduruss@gmail.com" && item.Password =="md12561256")
                    {
                        customer2.Email = item.Email;
                        customer2.Name = item.Name;
                    }
                }
                
                FormsAuthentication.SetAuthCookie(customer2.Name, false);
                ViewData["userLogin"] = customer2.Name;
                Session["UserInformation"] = customer2.Name;
                //ViewBag.Message = Session["UserInformation"].ToString();
                return RedirectToAction("Index", "Home");
            }
            
            return RedirectToAction("Index");
        }
        public ActionResult LoginControl()
        {
            return View();
        }
    }
}