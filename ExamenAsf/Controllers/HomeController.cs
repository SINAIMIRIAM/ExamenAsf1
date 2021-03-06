using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExamenAsf.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var conexion = new Conexion.BOLSA_EXAMENEntities();
            var listadoUsuarios = conexion.ALL_USERS();
            ViewBag.Listado = listadoUsuarios;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}