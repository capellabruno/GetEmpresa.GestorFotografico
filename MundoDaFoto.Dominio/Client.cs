using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MundoDaFoto.Dominio
{
    public class Client
    {
        public virtual long Id { get; set; }

        public virtual string Name { get; set; }

        public virtual string Email { get; set; }

        public virtual string Password { get; set; }

        public virtual City Municipio { get; set; }

        public virtual TypeClient Perfil { get; set; }

        public virtual bool Active { get; set; }

    }
}
