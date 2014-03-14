using System;

namespace GetEmpresa.GestorFotografico.Domain {
    public class TipoCliente {
        public virtual int Id { get; set; }

        public virtual string Nome { get; set; }

        public virtual string Descricao { get; set; }

        public virtual bool Ativo { get; set; }
    }
}
