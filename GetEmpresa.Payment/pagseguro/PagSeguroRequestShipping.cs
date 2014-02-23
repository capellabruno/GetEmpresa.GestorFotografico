using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetEmpresa.Payment.pagseguro
{
    public class PagSeguroRequestShipping
    {
        private PagSeguroRequestTypeShipping _type;

        public PagSeguroRequestTypeShipping Type
        {
            get { return _type; }
            set { _type = value; }
        }

        private PagSeguroRequestAddress _address;

        public PagSeguroRequestAddress Address
        {
            get { return _address; }
            set { _address = value; }
        }


    }
}
