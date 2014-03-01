using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetEmpresa.Payment.pagseguro
{
    public interface IPagSeguroPayment
    {
        PagSeguroResponse Checkout(PagSeguroRequest _domain, PagSeguroCredential _credential);
    }
}
