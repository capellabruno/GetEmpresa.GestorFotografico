using System;

namespace GetEmpresa.GestorFotografico.Domain {
    public class Cidade{
        public virtual long Id { get; set; }

        public virtual string Nome { get; set; }

        public virtual Estado Uf { get; set; }
    }
}

