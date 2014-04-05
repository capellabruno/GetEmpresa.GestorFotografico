using System;
using System.Collections.Generic;
using System.Linq;
using System.Transactions;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using DotNetOpenAuth.AspNet;
using Microsoft.Web.WebPages.OAuth;
using WebMatrix.WebData;
using MundoDaFoto.WebMvc4.Models;
using GetEmpresa.Negoc.Interface;
using MundoDaFoto.Dominio;

namespace MundoDaFoto.WebMvc4.Controllers {
    public class AccountController : Controller{
        private IClientNegoc _ClientNegoc;
        private ICountryNegoc _CountryNegoc;
        private IStateNegoc _StateNegoc;
        private ICityNegoc _CityNegoc;

        public AccountController(IClientNegoc ClientNegoc, ICountryNegoc CountryNegoc, IStateNegoc StateNegoc, ICityNegoc CityNegoc) {
            _ClientNegoc = ClientNegoc;
            _CountryNegoc = CountryNegoc;
            _StateNegoc = StateNegoc;
            _CityNegoc = CityNegoc;
        }

        // GET: /Account/LogOn
        public ActionResult LogOn() {
            return View();
        }

        //
        // POST: /Account/LogOn
        [HttpPost]
        public ActionResult LogOn(LogOnModel model, string returnUrl) {
            if (ModelState.IsValid) {
                if (Membership.ValidateUser(model.UserName, model.Password)) {
                    FormsAuthentication.SetAuthCookie(model.UserName, model.RememberMe);
                    if (Url.IsLocalUrl(returnUrl) && returnUrl.Length > 1 && returnUrl.StartsWith("/")
                        && !returnUrl.StartsWith("//") && !returnUrl.StartsWith("/\\")) {
                        return Redirect(returnUrl);
                    } else {
                        return RedirectToAction("Index", "Home");
                    }
                } else {
                    ModelState.AddModelError("", "The user name or password provided is incorrect.");
                }
            }

            // If we got this far, something failed, redisplay form
            return View(model);
        }

        //
        // POST: /Account/LogOn
        [HttpPost]
        public ActionResult AjaxLogOn(LogOnModel model, string returnUrl) {
            var provider = Membership.Provider;
            string name = provider.ApplicationName; // Get the application name here
            if (Membership.ValidateUser(model.UserName, model.Password)) {
                FormsAuthentication.SetAuthCookie(model.UserName, model.RememberMe);
                if (Url.IsLocalUrl(returnUrl) && returnUrl.Length > 1 && returnUrl.StartsWith("/")
                    && !returnUrl.StartsWith("//") && !returnUrl.StartsWith("/\\")) {
                    return Redirect(returnUrl);
                } else {
                    return RedirectToAction("Index", "Home");
                }
            } else {
                ModelState.AddModelError("", "The user name or password provided is incorrect.");                
                // If we got this far, something failed, redisplay form
                return View("LogOn", model);
            }            
        }

        //
        // GET: /Account/LogOff

        public ActionResult LogOff() {
            FormsAuthentication.SignOut();

            return RedirectToAction("Index", "Home");
        }

        //
        // GET: /Account/Register

        public ActionResult Register() {
            //Create Bags
            DataBindViewBagCountryes();        
            /*********************/

            return View();

        }

        private void DataBindViewBagCountryes()
        {
            IList<Country> _listaCountry = null;
            IList<SelectListItem> _listaBag = new List<SelectListItem>();

            _listaCountry = _CountryNegoc.BuscarTodos();

            if (_listaCountry != null && _listaCountry.Count > 0)

                foreach (Country item in _listaCountry)
                {
                    SelectListItem _sItem = new SelectListItem();
                    _sItem.Value = item.Id.ToString();
                    _sItem.Text = item.Name;

                    _listaBag.Add(_sItem);
                }

            ViewBag.Countryes = (from a in _listaBag select a);

        }

        //
        // POST: /Account/Register

        [HttpPost]
        public ActionResult Register(RegisterModel model) {
            if (ModelState.IsValid) {
                // Attempt to register the user
                MembershipCreateStatus createStatus;
                Membership.CreateUser(model.Email, model.Password, model.Email, null, null, true, null, out createStatus);

                if (createStatus == MembershipCreateStatus.Success) {
                    FormsAuthentication.SetAuthCookie(model.Email, false /* createPersistentCookie */);

                    //create account client on database mundo da foto
                    Client c = new Client();
                    c.Active = true;
                    c.Email = model.Email;
                    c.Name = model.Name;
                    c.Password = "not password in table";
                    c.Perfil = null;

                    this._ClientNegoc.Incluir(ref c);

                    return RedirectToAction("Index", "Home");
                } else {
                    ModelState.AddModelError("", ErrorCodeToString(createStatus));
                }
            }

            // If we got this far, something failed, redisplay form
            return View(model);
        }

        //
        // GET: /Account/ChangePassword

        [Authorize]
        public ActionResult ChangePassword() {
            return View();
        }

        //
        // POST: /Account/ChangePassword

        [Authorize]
        [HttpPost]
        public ActionResult ChangePassword(ChangePasswordModel model) {
            if (ModelState.IsValid) {

                // ChangePassword will throw an exception rather
                // than return false in certain failure scenarios.
                bool changePasswordSucceeded;
                try {
                    MembershipUser currentUser = Membership.GetUser(User.Identity.Name, true /* userIsOnline */);
                    changePasswordSucceeded = currentUser.ChangePassword(model.OldPassword, model.NewPassword);
                } catch (Exception) {
                    changePasswordSucceeded = false;
                }

                if (changePasswordSucceeded) {
                    return RedirectToAction("ChangePasswordSuccess");
                } else {
                    ModelState.AddModelError("", "The current password is incorrect or the new password is invalid.");
                }
            }

            // If we got this far, something failed, redisplay form
            return View(model);
        }

        //
        // GET: /Account/ChangePasswordSuccess

        public ActionResult ChangePasswordSuccess() {
            return View();
        }

        #region Status Codes
        private static string ErrorCodeToString(MembershipCreateStatus createStatus) {
            // See http://go.microsoft.com/fwlink/?LinkID=177550 for
            // a full list of status codes.
            switch (createStatus) {
                case MembershipCreateStatus.DuplicateUserName:
                    return "User name already exists. Please enter a different user name.";

                case MembershipCreateStatus.DuplicateEmail:
                    return "A user name for that e-mail address already exists. Please enter a different e-mail address.";

                case MembershipCreateStatus.InvalidPassword:
                    return "The password provided is invalid. Please enter a valid password value.";

                case MembershipCreateStatus.InvalidEmail:
                    return "The e-mail address provided is invalid. Please check the value and try again.";

                case MembershipCreateStatus.InvalidAnswer:
                    return "The password retrieval answer provided is invalid. Please check the value and try again.";

                case MembershipCreateStatus.InvalidQuestion:
                    return "The password retrieval question provided is invalid. Please check the value and try again.";

                case MembershipCreateStatus.InvalidUserName:
                    return "The user name provided is invalid. Please check the value and try again.";

                case MembershipCreateStatus.ProviderError:
                    return "The authentication provider returned an error. Please verify your entry and try again. If the problem persists, please contact your system administrator.";

                case MembershipCreateStatus.UserRejected:
                    return "The user creation request has been canceled. Please verify your entry and try again. If the problem persists, please contact your system administrator.";

                default:
                    return "An unknown error occurred. Please verify your entry and try again. If the problem persists, please contact your system administrator.";
            }
        }
        #endregion
    }
}
