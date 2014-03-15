using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MundoDaFoto.Dominio
{
    public class Pais
    {
        public virtual long Id { get; set; }

        public virtual string Nome { get; set; }

        public virtual string Sigla { get; set; }

        public virtual int Code { get; set; }


    }
}
