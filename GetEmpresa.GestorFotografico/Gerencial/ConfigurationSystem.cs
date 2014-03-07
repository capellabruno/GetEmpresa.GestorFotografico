using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetEmpresa.GestorFotografico.Domain.Gerencial
{
    public class ConfigurationSystem
    {
        private int _id;

        public virtual int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _facebook;
        public virtual string Facebook
        {
            get { return _facebook; }
            set { _facebook = value; }
        }

        private string _twiter;
        public virtual string Twiter
        {
            get { return _twiter; }
            set { _twiter = value; }
        }

        private string _googlePlus;
        public virtual string GooglePlus
        {
            get { return _googlePlus; }
            set { _googlePlus = value; }
        }

        private EnumFormaPagamento _formaPagamento;
        public virtual EnumFormaPagamento FormaPagamento
        {
            get { return _formaPagamento; }
            set { _formaPagamento = value; }
        }

        private int _codigoBanco;
        public virtual int CodigoBanco
        {
            get { return _codigoBanco; }
            set { _codigoBanco = value; }
        }

        private string _nomeBanco;
        public virtual string NomeBanco
        {
            get { return _nomeBanco; }
            set { _nomeBanco = value; }
        }

        private int _agencia;
        public virtual int Agencia
        {
            get { return _agencia; }
            set { _agencia = value; }
        }

        private int _digitoAgencia;
        public virtual int DigitoAgencia
        {
            get { return _digitoAgencia; }
            set { _digitoAgencia = value; }
        }

        private long _contaBanco;
        public virtual long ContaBanco
        {
            get { return _contaBanco; }
            set { _contaBanco = value; }
        }

        private long _digitoConta;
        public virtual long DigitoConta
        {
            get { return _digitoConta; }
            set { _digitoConta = value; }
        }

        private string _emailPagSeguro;
        public virtual string EmailPagSeguro
        {
            get { return _emailPagSeguro; }
            set { _emailPagSeguro = value; }
        }

        private string _tokenPagSeguro;
        public virtual string TokenPagSeguro
        {
            get { return _tokenPagSeguro; }
            set { _tokenPagSeguro = value; }
        }

        private string _emailPayPal;
        public virtual string EmailPayPal
        {
            get { return _emailPayPal; }
            set { _emailPayPal = value; }
        }

        private string _tokenPayPal;
        public virtual string TokenPayPal
        {
            get { return _tokenPayPal; }
            set { _tokenPayPal = value; }
        }

        private ClientePortal _cliente;

        public virtual ClientePortal Cliente
        {
            get { return _cliente; }
            set { _cliente = value; }
        }
    }
}
