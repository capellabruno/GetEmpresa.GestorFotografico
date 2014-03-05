using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GetEmpresa.Negoc;
using GetEmpresa.GestorFotografico;

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

            GetEmpresa.GestorFotografico.Domain.Gerencial.ClientePortal _clientePortal = new GetEmpresa.GestorFotografico.Domain.Gerencial.ClientePortal();
            _clientePortal.Ativo = true;
            _clientePortal.Bairro = "Tijuca";
            _clientePortal.Cep = "20520052";
            _clientePortal.Cidade = "Rio de Janeiro";
            _clientePortal.Complemento = "Apto 301";
            _clientePortal.Documento = "09648943788";
            _clientePortal.Email = "bruno.capella@getempresa.com.br";
            _clientePortal.Endereco = "Rua Conde de Bonfim 601";
            _clientePortal.Nome = "Bruno Capella Vilela";
            _clientePortal.Pais = "Brasil";
            _clientePortal.Telefone = "973410100";
            _clientePortal.Uf = "RJ";

            this.ClienteNegoc.IncluirClientePortal(ref _clientePortal);

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
