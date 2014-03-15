using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MundoDaFoto.Dominio
{
    public class Cidade
    {

        public virtual long Id { get; set; }

        public virtual string Nome { get; set; }

        public virtual Estado Uf { get; set; }
    }
}
