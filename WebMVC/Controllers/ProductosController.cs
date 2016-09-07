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

            //cargo los combos
            CategoriaRepository cb = new CategoriaRepository();
            ViewBag.Categoria_1 = cb.ObtenerCategoria(1);
            ViewBag.Categoria_0 = cb.ObtenerCategoria(0);


            ProductosRepository pr = new ProductosRepository();
            ViewBag.Productos = pr.Productos_nivel1("");

            return View();

        }
    }
}
