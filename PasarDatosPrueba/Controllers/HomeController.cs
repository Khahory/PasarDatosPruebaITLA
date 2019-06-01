using PasarDatosPrueba.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PasarDatosPrueba.Controllers
{
    public class HomeController : Controller
    {
           
        public ActionResult Index()
        {
            Persona persona = new Persona()
            {
                Nombre = "Angel"
            };

            //varible temporal el "nombre" seria como un id para identificar el tempData
            TempData["nombre"] = persona.Nombre;
            
            return View(persona);
        }

        public ActionResult About()
        {

            //aqui solo llamo el contenido del tempData con el id "nombre"
            string nombreVar = TempData["nombre"].ToString();

            ViewBag.Message = nombreVar;
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}