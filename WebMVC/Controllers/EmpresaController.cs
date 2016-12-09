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
    public class EmpresaController : Controller
    {
        public ActionResult Nuestra_Empresa()
        {
            return View();

        }
        public ActionResult Contacto()
        {
            if (Request.Form["email"] != null)
            {
                try
                {
                    EmailRepository cb = new EmailRepository();
                    cb.SendEmail(Request.Form["email"], "Solicitante: " + Request.Form["nombre"] + " ; Telefono: " + Request.Form["telefono"], Request.Form["consulta"], false);
                    return RedirectToAction("Mensaje", "Home", new { rec = "1", msj = "Mensaje enviado" });
      
                }
                catch (Exception)
                {

                   return RedirectToAction("Mensaje", "Home", new { rec = "0", msj = "Error al enviar el mensaje" });
      
                }
                   }
            else
            { 
            return View();
            }
        }
    }
}
