using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MundoDaFoto.Dominio
{
    public class TipoCliente
    {
        public virtual int Id { get; set; }

        public virtual string Nome { get; set; }

        public virtual string Descricao { get; set; }

        public virtual bool Ativo { get; set; }

    }
}
