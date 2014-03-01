using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetEmpresa.Payment.pagseguro
{
    public class PagSeguroCredential
    {
        private string _email;

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        private string _token;

        public string Token
        {
            get { return _token; }
            set { _token = value; }
        }
    }
}
