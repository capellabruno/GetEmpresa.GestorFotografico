using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MundoDaFoto.Dominio
{
    public class City
    {

        public virtual long Id { get; set; }

        public virtual string Name { get; set; }

        public virtual State Uf { get; set; }

        public virtual bool Active { get; set; }
    }
}
