using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MundoDaFoto.Dominio;

namespace GetEmpresa.Negoc.Interface
{
    public interface ITipoClienteNegoc
    {
        IList<TipoCliente> BuscarTodos();
        TipoCliente BuscarPorId(long id);
    }
}
