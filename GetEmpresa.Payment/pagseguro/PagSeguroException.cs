using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetEmpresa.Payment.pagseguro
{
    public class PagSeguroException : Exception
    {
        public PagSeguroException(string _message) : base(_message) { }

        public PagSeguroException(string _message, Exception _ex) : base(_message, _ex) { }
    }
}
