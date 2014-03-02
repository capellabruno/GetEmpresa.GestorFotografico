using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetEmpresa.GestorFotografico.Domain.Portifolio
{
    public class Portifolio
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

        private Gerencial.ClientePortal _cliente;

        public virtual Gerencial.ClientePortal Cliente
        {
            get { return _cliente; }
            set { _cliente = value; }
        }

        private IList<Imagem> _imagens;

        public virtual IList<Imagem> Imagens
        {
            get { return _imagens; }
            set { _imagens = value; }
        }

        private string _descricao;

        public virtual string Descricao
        {
            get { return _descricao; }
            set { _descricao = value; }
        }


    }
}
