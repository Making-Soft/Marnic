using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using WebMVC.Persistencia;
using WebMVC.Models;

namespace WebMVC.Controllers
{
    public class ProductosController : Controller
    {
        public ActionResult Index()
        {


            CategoriaRepository cb = new CategoriaRepository();
            ViewBag.Categoria_0 = cb.Categoria("in(0)");            
            ViewBag.Categoria_1 = cb.Categoria("in(1,2,3,4,5,6,7,8,9,10)");
            return View();


        }
    }
}
