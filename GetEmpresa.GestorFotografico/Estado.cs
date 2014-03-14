using System;

namespace GetEmpresa.GestorFotografico.Domain {
    public class Estado {
        public virtual long Id { get; set; }
        public virtual string Nome { get; set; }
        public virtual string Sigla { get; set; }
        public virtual Pais Pais { get; set; }
    }
}
