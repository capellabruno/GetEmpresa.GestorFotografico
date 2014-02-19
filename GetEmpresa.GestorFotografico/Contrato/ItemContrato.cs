using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetEmpresa.GestorFotografico.Domain.Contrato
{
    public class ItemContrato
    {
        private long _id;

        public virtual long Id
        {
            get { return _id; }
            set { _id = value; }
        }
        private Gerencial.TipoItemContrato _tipo;

        public virtual Gerencial.TipoItemContrato Tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }
        private string _texto;

        public virtual string Texto
        {
            get { return _texto; }
            set { _texto = value; }
        }
        private DateTime _dataCriacao;

        public virtual DateTime DataCriacao
        {
            get { return _dataCriacao; }
            set { _dataCriacao = value; }
        }
    }
}
