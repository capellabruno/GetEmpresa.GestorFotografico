using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GetEmpresa.Negoc;
using GetEmpresa.GestorFotografico;
using GetEmpresa.Negoc.Interface;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        private IClienteNegoc _clienteNegoc;

        public IClienteNegoc ClienteNegoc
        {
            get { return _clienteNegoc; }
            set { _clienteNegoc = value; }
        }


        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
