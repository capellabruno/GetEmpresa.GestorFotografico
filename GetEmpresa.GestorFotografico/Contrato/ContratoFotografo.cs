using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetEmpresa.GestorFotografico.Domain.Contrato
{
    public class ContratoFotografo
    {
        private long _id;

        public virtual long Id
        {
            get { return _id; }
            set { _id = value; }
        }
        private string _nomeContrato;

        public virtual string NomeContrato
        {
            get { return _nomeContrato; }
            set { _nomeContrato = value; }
        }

        private Gerencial.TipoContrato _tipo;

        public virtual Gerencial.TipoContrato Tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }
        private DateTime _dataValidade;

        public virtual DateTime DataValidade
        {
            get { return _dataValidade; }
            set { _dataValidade = value; }
        }
        private IList<ItemContrato> _itensContrato;

        public virtual IList<ItemContrato> ItensContrato
        {
            get { return _itensContrato; }
            set { _itensContrato = value; }
        }

        private DateTime _dataCriacao;

        public virtual DateTime DataCriacao
        {
            get { return _dataCriacao; }
            set { _dataCriacao = value; }
        }


    }
}
