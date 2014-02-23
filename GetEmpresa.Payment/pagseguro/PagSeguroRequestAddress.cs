using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetEmpresa.Payment.pagseguro
{
    public class PagSeguroRequestAddress
    {
        private string _street;

        public string Street
        {
            get { return _street; }
            set { _street = value; }
        }

        private string _number;

        public string Number
        {
            get { return _number; }
            set { _number = value; }
        }

        private string _complement;

        public string Complement
        {
            get { return _complement; }
            set { _complement = value; }
        }

        private string _district;

        public string District
        {
            get { return _district; }
            set { _district = value; }
        }

        private string _postalCode;

        public string PostalCode
        {
            get { return _postalCode; }
            set { _postalCode = value; }
        }

        private string _city;

        public string City
        {
            get { return _city; }
            set { _city = value; }
        }

        private string _stade;

        public string Stade
        {
            get { return _stade; }
            set { _stade = value; }
        }

        private string _country;

        public string Country
        {
            get { return _country; }
            set { _country = value; }
        }


    }
}
