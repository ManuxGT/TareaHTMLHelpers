using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TareaHelpers.Models;

namespace TareaHelpers.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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

        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        public ActionResult Registrar()
        {
           
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Registrar(string nombre,string apellido,string cedula,int edad, string telefono,
            string estado_civil, string correo,bool Videojuegos, string genero, bool Gimnasio, bool Leer, bool Musica)
        {
            
            
            Persona alguien = new Persona();
            alguien.nombre = nombre;
            alguien.apellido = apellido;
            alguien.correo = correo;
            alguien.cedula = cedula;
            alguien.edad = edad;
            alguien.genero = genero;
            alguien.telefono = genero;
            alguien.estado_civil = estado_civil;

            if (Videojuegos)
            {
                string v = "Videojuegos";
                alguien.hobbies.Add(v);
            }

            if (Leer)
            {
                string l = "Leer";
                alguien.hobbies.Add(l);
            }

            if (Musica)
            {
                string m = "Escuchar musica";
                alguien.hobbies.Add(m);
            }

            if (Gimnasio)
            {
                string g = "Ir al gimnasio";
                alguien.hobbies.Add(g);
            }

            if (Persona.IsValidEmail(correo))
            {
                return View("Datos", alguien);
            }
            else
            {
                ViewBag.ErrorPerez = "Dirección de correo electrónica no válida";
                return View();
            }
            
        }

        public ActionResult Datos()
        {
            return View();
        }

    }
}