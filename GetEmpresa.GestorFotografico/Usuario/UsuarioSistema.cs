using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetEmpresa.GestorFotografico.Domain.Usuario
{
    public class UsuarioSistema
    {
        private long _id;

        public virtual long Id
        {
            get { return _id; }
            set { _id = value; }
        }
        private string _loginAcesso;

        public virtual string LoginAcesso
        {
            get { return _loginAcesso; }
            set { _loginAcesso = value; }
        }
        private string _senhaAcesso;

        public virtual string SenhaAcesso
        {
            get { return _senhaAcesso; }
            set { _senhaAcesso = value; }
        }
        private DateTime _dataCriacao;

        public virtual DateTime DataCriacao
        {
            get { return _dataCriacao; }
            set { _dataCriacao = value; }
        }
        private DateTime _dataTrocaSenha;

        public virtual DateTime DataTrocaSenha
        {
            get { return _dataTrocaSenha; }
            set { _dataTrocaSenha = value; }
        }
        private DateTime _dataAlteracao;

        public virtual DateTime DataAlteracao
        {
            get { return _dataAlteracao; }
            set { _dataAlteracao = value; }
        }
        private bool _ativo;

        public virtual bool Ativo
        {
            get { return _ativo; }
            set { _ativo = value; }
        }

        private GrupoUsuario _grupo;

        public virtual GrupoUsuario Grupo
        {
            get { return _grupo; }
            set { _grupo = value; }
        }

    }
}
