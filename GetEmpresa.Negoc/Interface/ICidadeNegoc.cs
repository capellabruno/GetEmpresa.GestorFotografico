using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MundoDaFoto.Dominio;

namespace GetEmpresa.Negoc.Interface
{
    public interface ICidadeNegoc
    {
        IList<Cidade> BuscarTodos(long idEstado);
        Cidade BuscarPorId(long idCidade);

    }
}
