using GetEmpresa.Negoc.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MundoDaFoto.WebMvc4.Areas.Photographer.Models;
using MundoDaFoto.Dominio.Photographer;

namespace MundoDaFoto.WebMvc4.Areas.Photographer.Controllers{
    [Authorize]
    public class ProfileController : BasePhotographerController{

        private IPhotographerService _photographerService;
        public ProfileController(IPhotographerService photographerService) {
            _photographerService = photographerService;
        }

        //
        // GET: /Photographer/Profile/
        public ActionResult Index(){
            return View();
        }

        //
        // GET: /Photographer/Profile/Details/5

        public ActionResult Details(int id){
            return View();
        }

        //
        // GET: /Photographer/Profile/Create

        public ActionResult Create(){
            var email = HttpContext.User.Identity.Name;
            return View();
        }

        //
        // POST: /Photographer/Profile/Create

        [HttpPost]
        public ActionResult Create(PhotographerRegisterModel photographerRegisterModel){
            try{
                var email = HttpContext.User.Identity.Name;

                PhotographerProfile profile = new PhotographerProfileBuilder(email)
                                                                .AddBasicInfo(photographerRegisterModel.Name, photographerRegisterModel.BirthDate, photographerRegisterModel.Gender)
                                                                .AddContactInfo(photographerRegisterModel.AlternateEmail, photographerRegisterModel.WebSite, photographerRegisterModel.ContactPhone1, photographerRegisterModel.ContactPhone2, photographerRegisterModel.IWantToBeContacted, photographerRegisterModel.Address)
                                                                .Build();

                _photographerService.CreateNewProfile(profile);
                return RedirectToAction("Index", "Home");
            }catch{
                return View();
            }
        }

        //
        // GET: /Photographer/Profile/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Photographer/Profile/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Photographer/Profile/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Photographer/Profile/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
