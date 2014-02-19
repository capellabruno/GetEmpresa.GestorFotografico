using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetEmpresa.GestorFotografico.Domain.Financeiro
{
    public class PlanoFinanceiro
    {
        private long _id;

        public virtual long Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private Divida _dividaCliente;

        public virtual Divida DividaCliente
        {
            get { return _dividaCliente; }
            set { _dividaCliente = value; }
        }

        private Gerencial.ClientePortal _clientePai;

        public virtual Gerencial.ClientePortal ClientePai
        {
            get { return _clientePai; }
            set { _clientePai = value; }
        }

    }
}
