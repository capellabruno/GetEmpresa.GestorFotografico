using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MundoDaFoto.Dominio.Photographer {
    public class NullPhotographerProfile : PhotographerProfile{
        public override bool IsNull() {
            return true;
        }
    } //class
}
