using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetEmpresa.GestorFotografico.Domain.Cliente
{
    public class Cliente : Gerencial.Client
    {        
        private Gerencial.ClientePortal _clientePai;

        public virtual Gerencial.ClientePortal ClientePai
        {
            get { return _clientePai; }
            set { _clientePai = value; }
        }

    }
}
