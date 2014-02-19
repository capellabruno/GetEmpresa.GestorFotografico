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

        private IList<Cobranca> _cobrancas;

        public virtual IList<Cobranca> Cobrancas
        {
            get { return _cobrancas; }
            set { _cobrancas = value; }
        }

    }
}
