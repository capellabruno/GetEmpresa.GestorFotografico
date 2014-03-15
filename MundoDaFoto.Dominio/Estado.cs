using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MundoDaFoto.Dominio
{
    public class Estado
    {
        public virtual long Id { get; set; }
        public virtual string Nome { get; set; }
        public virtual string Sigla { get; set; }
        public virtual Pais Pais { get; set; }
    }
}
