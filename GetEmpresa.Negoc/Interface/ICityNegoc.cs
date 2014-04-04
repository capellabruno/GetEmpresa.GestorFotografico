using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MundoDaFoto.Dominio;

namespace GetEmpresa.Negoc.Interface
{
    public interface ICityNegoc
    {
        IList<City> BuscarTodos(long idState);
        City BuscarPorId(long idCity);

    }
}
