using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab2.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {

            string[] products = {"laptop", "tablet" , "desktop" };
          
            ViewData["product"] = products;
            return View();
        }
        public String Details(String[] product) {


            String Message = "you have selected " + product;
            return Message ;
        }
    }
}
