using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace WebMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();

        }
        public ActionResult Mensaje()
        {

            if (Request.QueryString["rec"] == "1")
            {
                if (string.IsNullOrEmpty(Request.QueryString["msj"]) == false)
                {
                    string msj = Request.QueryString["msj"];
                    ViewBag.Message = msj;
                }
                else
                {
                    ViewBag.Message = "";
                }
            }
            else
            {
                string msj = Request.QueryString["msj"];
                ViewBag.Message = msj;
            }
            return View();
        }
    }
}
