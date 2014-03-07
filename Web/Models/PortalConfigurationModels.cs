using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Globalization;
using System.Web.Security;
using GetEmpresa.GestorFotografico.Domain.Gerencial;

namespace Web.Models
{
    public class PortalConfigurationModels
    {

        private string _facebook;

        [DataType(System.ComponentModel.DataAnnotations.DataType.Url)]
        [Display(Name="URL Facebook")]
        public string Facebook
        {
            get { return _facebook; }
            set { _facebook = value; }
        }

        private string _twiter;

        [DataType(System.ComponentModel.DataAnnotations.DataType.Url)]
        [Display(Name = "URL Twiter")]
        public string Twiter
        {
            get { return _twiter; }
            set { _twiter = value; }
        }

        private string _googlePlus;

        [DataType(System.ComponentModel.DataAnnotations.DataType.Text)]
        [Display(Name = "URL Google+")]
        public string GooglePlus
        {
            get { return _googlePlus; }
            set { _googlePlus = value; }
        }
        
        private EnumFormaPagamento _formaPagamento;

        [Required(ErrorMessage="Tipo de Pagamento deve ser informado")]
        [DataType(System.ComponentModel.DataAnnotations.DataType.Custom)]
        [Display(Name="Forma de Pagamento")]
        public EnumFormaPagamento FormaPagamento
        {
            get { return _formaPagamento; }
            set { _formaPagamento = value; }
        }

        private int _codigoBanco;

        [DataType(System.ComponentModel.DataAnnotations.DataType.Text)]
        [Display(Name = "Código do Banco")]
        public int CodigoBanco
        {
            get { return _codigoBanco; }
            set { _codigoBanco = value; }
        }

        private string _nomeBanco;

        [DataType(System.ComponentModel.DataAnnotations.DataType.Text)]
        [Display(Name = "Nome do Banco")]
        public string NomeBanco
        {
            get { return _nomeBanco; }
            set { _nomeBanco = value; }
        }

        private int _agencia;

        [DataType(System.ComponentModel.DataAnnotations.DataType.Text)]
        [Display(Name = "Codigo da Agência")]
        public int Agencia
        {
            get { return _agencia; }
            set { _agencia = value; }
        }

        private int _digitoAgencia;

        [DataType(System.ComponentModel.DataAnnotations.DataType.Text)]
        [Display(Name = "Digito da Agência")]
        public int DigitoAgencia
        {
            get { return _digitoAgencia; }
            set { _digitoAgencia = value; }
        }

        private long _contaBanco;

        [DataType(System.ComponentModel.DataAnnotations.DataType.Text)]
        [Display(Name = "Conta Bancária")]
        public long ContaBanco
        {
            get { return _contaBanco; }
            set { _contaBanco = value; }
        }

        private long _digitoConta;

        [DataType(System.ComponentModel.DataAnnotations.DataType.Text)]
        [Display(Name = "Digito Conta")]
        public long DigitoConta
        {
            get { return _digitoConta; }
            set { _digitoConta = value; }
        }

        private string _emailPagSeguro;

        [DataType(System.ComponentModel.DataAnnotations.DataType.EmailAddress)]
        [Display(Name = "E-Mail PagSeguro")]
        public string EmailPagSeguro
        {
            get { return _emailPagSeguro; }
            set { _emailPagSeguro = value; }
        }

        private string _tokenPagSeguro;

        [DataType(System.ComponentModel.DataAnnotations.DataType.Text)]
        [Display(Name = "Token PagSeguro")]
        public string TokenPagSeguro
        {
            get { return _tokenPagSeguro; }
            set { _tokenPagSeguro = value; }
        }

        private string _emailPayPal;

        [DataType(System.ComponentModel.DataAnnotations.DataType.EmailAddress)]
        [Display(Name = "E-mail PayPal")]
        public string EmailPayPal
        {
            get { return _emailPayPal; }
            set { _emailPayPal = value; }
        }

        private string _tokenPayPal;

        [DataType(System.ComponentModel.DataAnnotations.DataType.Text)]
        [Display(Name = "Token do Paypal")]
        public string TokenPayPal
        {
            get { return _tokenPayPal; }
            set { _tokenPayPal = value; }
        }

        private ClientePortal _cliente;

        public ClientePortal Cliente
        {
            get { return _cliente; }
            set { _cliente = value; }
        }

    }
}