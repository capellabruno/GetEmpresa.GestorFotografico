using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetEmpresa.GestorFotografico.Domain.Gerencial
{
    public class ClientePortal
    {
        private long _id;

        public virtual long Id
        {
            get { return _id; }
            set { _id = value; }
        }

    }
}
