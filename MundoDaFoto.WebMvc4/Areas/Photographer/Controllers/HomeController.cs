using GetEmpresa.Negoc.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MundoDaFoto.WebMvc4.Areas.Photographer.Controllers{
    [Authorize]
    public class HomeController : Controller{

        private IPhotographerService _photographerService;
        public HomeController(IPhotographerService photographerService) {
            _photographerService = photographerService;
        }

        //
        // GET: /Photographer/Home/
        public ActionResult Index(){
            var userLoggedEmail = HttpContext.User.Identity.Name;
            if (_photographerService.GetProfile(userLoggedEmail).IsNull())
                return View("NoProfile");

            return View();
        }

    }// class
}
