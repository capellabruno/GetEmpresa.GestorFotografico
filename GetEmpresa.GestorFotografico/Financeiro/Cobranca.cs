using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetEmpresa.GestorFotografico.Domain.Financeiro
{
    public class Cobranca
    {
        private long _id;

        public virtual long Id
        {
            get { return _id; }
            set { _id = value; }
        }
        private DateTime _dataCriacao;

        public virtual DateTime DataCriacao
        {
            get { return _dataCriacao; }
            set { _dataCriacao = value; }
        }
        private DateTime _dataCobranca;

        public virtual DateTime DataCobranca
        {
            get { return _dataCobranca; }
            set { _dataCobranca = value; }
        }
        private DateTime _dataFaturamento;

        public virtual DateTime DataFaturamento
        {
            get { return _dataFaturamento; }
            set { _dataFaturamento = value; }
        }
        private string _faturamento;

        public virtual string Faturamento
        {
            get { return _faturamento; }
            set { _faturamento = value; }
        }
        private decimal _valorCobranca;

        public virtual decimal ValorCobranca
        {
            get { return _valorCobranca; }
            set { _valorCobranca = value; }
        }
        private decimal _dataVencimento;

        public virtual decimal DataVencimento
        {
            get { return _dataVencimento; }
            set { _dataVencimento = value; }
        }
        private string _descricao;

        public virtual string Descricao
        {
            get { return _descricao; }
            set { _descricao = value; }
        }
        private string _instrucaoPagamento;

        public virtual string InstrucaoPagamento
        {
            get { return _instrucaoPagamento; }
            set { _instrucaoPagamento = value; }
        }
        private ResponsavelFinanceiro _resposanvel;

        public virtual ResponsavelFinanceiro Resposanvel
        {
            get { return _resposanvel; }
            set { _resposanvel = value; }
        }
       
    }
}
