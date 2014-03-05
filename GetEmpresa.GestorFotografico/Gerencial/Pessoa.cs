using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetEmpresa.GestorFotografico.Domain.Gerencial
{
    public abstract class Pessoa
    {
        private long _id;
        public virtual long Id
        {
            get { return _id; }
            set { _id = value; }
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


        private string _endereco;
        public virtual string Endereco
        {
            get { return _endereco; }
            set { _endereco = value; }
        }

        private string _cidade;
        public virtual string Cidade
        {
            get { return _cidade; }
            set { _cidade = value; }
        }

        private string _uf;
        public virtual string Uf
        {
            get { return _uf; }
            set { _uf = value; }
        }

        private string _pais;
        public virtual string Pais
        {
            get { return _pais; }
            set { _pais = value; }
        }

        private string _bairro;
        public virtual string Bairro
        {
            get { return _bairro; }
            set { _bairro = value; }
        }

        private string _complemento;
        public virtual string Complemento
        {
            get { return _complemento; }
            set { _complemento = value; }
        }

        private string _cep;
        public virtual string Cep
        {
            get { return _cep; }
            set { _cep = value; }
        }

        private string _documento;
        public virtual string Documento
        {
            get { return _documento; }
            set { _documento = value; }
        }

        private string _telefone;
        public virtual string Telefone
        {
            get { return _telefone; }
            set { _telefone = value; }
        }

        private bool _ativo;
        public virtual bool Ativo
        {
            get { return _ativo; }
            set { _ativo = value; }
        }

    }
}
