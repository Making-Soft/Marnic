using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace WebMVC.Controllers
{
    public class EmpresaController : Controller
    {
        public ActionResult Nuestra_Empresa()
        {
            return View();

        }
    }
}
