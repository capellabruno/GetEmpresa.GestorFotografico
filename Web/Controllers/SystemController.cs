using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GetEmpresa.Negoc;
using GetEmpresa.GestorFotografico.Domain.Gerencial;

namespace Web.Controllers
{
    public class SystemController : Controller
    {
        #region "Dependency Injection"
        private IClienteNegoc _clienteNegoc;

        public IClienteNegoc ClienteNegoc
        {
            get { return _clienteNegoc; }
            set { _clienteNegoc = value; }
        }

        #endregion

        //
        // GET: /System/

        public ActionResult Index()
        {
            string _usuario = User.Identity.Name;

            ConfigurationSystem _config;

            _config = this.ClienteNegoc.GetConfigurarion(_usuario);

            if (_config != null && _config.Id > 0)
            {
                Models.PortalConfigurationModels _view;
                _view = new Models.PortalConfigurationModels();

                Filters.Transcritor.TranscreveWeb(_config, _view);

                ViewBag.TipoPagamentoSelecionado = _config.FormaPagamento;

                return View(_view);
            }

            return View();
        }

        //
        // GET: /System/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /System/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /System/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /System/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /System/Edit/5

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
        // GET: /System/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /System/Delete/5

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

        public ActionResult Administrator()
        {
            return View();
        }
    }
}
