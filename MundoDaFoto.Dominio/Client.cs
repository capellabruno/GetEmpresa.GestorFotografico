using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MundoDaFoto.Domain{
    public class Client{
        public virtual long Id { get; set; }

        public virtual string Name { get; set; }

        public virtual string Email { get; set; }

        public virtual string Password { get; set; }

        public virtual City Municipio { get; set; }

        //TODO: Definir no futuro com bruninho como ficará o perfil. Será um discrminator? Será um role? Será uma Classe?
        public virtual string Perfil { get; set; }

        public virtual bool Active { get; set; }
    }// class
}
