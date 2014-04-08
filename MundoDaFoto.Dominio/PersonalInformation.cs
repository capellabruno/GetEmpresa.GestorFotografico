using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MundoDaFoto.Domain
{
    public class PersonalInformation
    {
        private long _id;

        public virtual long Id
        {
            get { return _id; }
            set { _id = value; }
        }


        private string _zipCode;

        public virtual string ZipCode
        {
            get { return _zipCode; }
            set { _zipCode = value; }
        }
        private int _number;

        public virtual int Number
        {
            get { return _number; }
            set { _number = value; }
        }
        private string _complement;

        public virtual string Complement
        {
            get { return _complement; }
            set { _complement = value; }
        }

        private City _selectedCity;

        public virtual City City
        {
            get { return _selectedCity; }
            set { _selectedCity = value; }
        }
        private string _bairro;

        public virtual string Bairro
        {
            get { return _bairro; }
            set { _bairro = value; }
        }
        private string _cpf;

        public virtual string Cpf
        {
            get { return _cpf; }
            set { _cpf = value; }
        }
        private string _cnpj;

        public virtual string Cnpj
        {
            get { return _cnpj; }
            set { _cnpj = value; }
        }

        private Client _client;

        public virtual Client Client
        {
            get { return _client; }
            set { _client = value; }
        }

        private char _typeClient;

        public virtual char TypeClient
        {
            get { return _typeClient; }
            set { _typeClient = value; }
        }
    }
}
