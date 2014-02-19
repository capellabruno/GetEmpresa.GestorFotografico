using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetEmpresa.GestorFotografico.Domain.Financeiro
{
    public class Pagamento
    {
        private long _id;

        public virtual long Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private Cobranca _cobrancaPaga;

        public virtual Cobranca CobrancaPaga
        {
            get { return _cobrancaPaga; }
            set { _cobrancaPaga = value; }
        }
        private DateTime _dataPagamento;

        public virtual DateTime DataPagamento
        {
            get { return _dataPagamento; }
            set { _dataPagamento = value; }
        }
        private decimal _valorPago;

        public virtual decimal ValorPago
        {
            get { return _valorPago; }
            set { _valorPago = value; }
        }
    }
}
