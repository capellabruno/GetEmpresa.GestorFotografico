using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MundoDaFoto.Dominio;

namespace GetEmpresa.Negoc.Interface
{
    public interface IEstadoNegoc
    {
        IList<Estado> BuscarTodos(long _idPais);
        Estado BuscarPorId(long idEstado);

    }
}
