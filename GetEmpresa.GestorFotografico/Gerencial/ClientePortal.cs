using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetEmpresa.GestorFotografico.Domain.Gerencial
{
    public class ClientePortal : Pessoa
    {
        private ConfigurationSystem _configuration;

        public virtual ConfigurationSystem Configuration
        {
            get { return _configuration; }
            set { _configuration = value; }
        }

        private string _password;

        public virtual string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        private DateTime? _dataProximatroca;

        public virtual DateTime? DataProximatroca
        {
            get { return _dataProximatroca; }
            set { _dataProximatroca = value; }
        }

        private string _urlPessoal;

        public virtual string UrlPessoal
        {
            get { return _urlPessoal; }
            set { _urlPessoal = value; }
        }

    }
}
