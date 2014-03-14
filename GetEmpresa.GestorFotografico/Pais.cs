using System;

namespace GetEmpresa.GestorFotografico.Domain {
    public class Pais {
        public virtual long Id { get; set; }

        public virtual string Nome { get; set; }

        public virtual string Sigla { get; set; }

        public virtual int Code { get; set; }
    }
}
