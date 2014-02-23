using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetEmpresa.Payment.pagseguro
{
    public class PagSeguroRequest
    {

        private EnumCurrency _currency;

        public EnumCurrency Currency
        {
            get { return _currency; }
            set { _currency = value; }
        }

        private string _reference;

        public string Reference
        {
            get { return _reference; }
            set { _reference = value; }
        }

        private IList<PagSeguroRequestItem> _itens;

        public IList<PagSeguroRequestItem> Itens
        {
            get { return _itens; }
            set { _itens = value; }
        }

        private PagSeguroRequestSender _sender;

        public PagSeguroRequestSender Sender
        {
            get { return _sender; }
            set { _sender = value; }
        }

        private PagSeguroRequestShipping _shipping;

        public PagSeguroRequestShipping Shipping
        {
            get { return _shipping; }
            set { _shipping = value; }
        }

    }
}
