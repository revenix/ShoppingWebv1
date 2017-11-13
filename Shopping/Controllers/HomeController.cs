using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VentaData;
using VentaService.Login;

namespace Shopping.Controllers
{
    public class HomeController : Controller
    {
        LoginService _LoginService = new LoginService();
        public ActionResult Index()
        {
            //Valido si la session existe
            if ((Session["Login"]) != null)
            {
                string email = (string)(Session["email"]);
                ViewBag.ValidarSession = 1;
                ViewBag.CorreoUsuario = email;
                ;
            }
            else
            {
                ViewBag.ValidarSession = 0;
            }

            return View();
        }

        public ActionResult Login()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult IniciarSession(string ID_Email, string Password)
        {
            List<sp_login_Result> listLog = new List<sp_login_Result>();
            int flag;
            listLog = _LoginService.Validar_InicioSesion(ID_Email, Password);
            flag = listLog.Count;
            if (flag == 1)
            {
                string email = listLog[0].email;
                System.Web.HttpContext.Current.Session["Login"] = true;
                System.Web.HttpContext.Current.Session["email"] = email;
                return RedirectToAction("Index", "Home");
            }else
            {
                //Aqui debes de implementar que pasará en caso de que no sea
                //las credeniales no sean las correctas
                //
                return RedirectToAction("Login", "Home"); 
            }
        }

        public ActionResult SignOut()
        {
            Session.Remove("Login");
            Session.Remove("email");
            return RedirectToAction("Index", "Home");
        }
    }
}