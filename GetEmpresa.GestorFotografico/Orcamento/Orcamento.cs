using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetEmpresa.GestorFotografico.Domain.Orcamento
{
    public class Orcamento
    {
        private long _id;

        public virtual long Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private DateTime _dataPrevistaEvento;

        public virtual DateTime DataPrevistaEvento
        {
            get { return _dataPrevistaEvento; }
            set { _dataPrevistaEvento = value; }
        }

        private DateTime _dataValidadeOrcamento;

        public virtual DateTime DataValidadeOrcamento
        {
            get { return _dataValidadeOrcamento; }
            set { _dataValidadeOrcamento = value; }
        }

        private string _nome;

        public virtual string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        private string _email;

        public virtual string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        private string _localEvento;

        public virtual string LocalEvento1
        {
            get { return _localEvento; }
            set { _localEvento = value; }
        }

        public virtual string LocalEvento
        {
            get { return _localEvento; }
            set { _localEvento = value; }
        }

        private Gerencial.TipoEnsaio _tipoOrcamento;

        public virtual Gerencial.TipoEnsaio TipoOrcamento
        {
            get { return _tipoOrcamento; }
            set { _tipoOrcamento = value; }
        }

        private Gerencial.ClientePortal _clientePortalOrcamento;

        public virtual Gerencial.ClientePortal ClientePortalOrcamento
        {
            get { return _clientePortalOrcamento; }
            set { _clientePortalOrcamento = value; }
        }

        private string _mensagem;

        public virtual string Mensagem
        {
            get { return _mensagem; }
            set { _mensagem = value; }
        }
        
    }
}
