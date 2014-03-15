using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MundoDaFoto.Dominio
{
    public class Cliente
    {
        public virtual long Id { get; set; }

        public virtual string Nome { get; set; }

        public virtual string Email { get; set; }

        public virtual string Senha { get; set; }

        public virtual Cidade Municipio { get; set; }

        public virtual TipoCliente Perfil { get; set; }

        public virtual bool Ativo { get; set; }

    }
}
