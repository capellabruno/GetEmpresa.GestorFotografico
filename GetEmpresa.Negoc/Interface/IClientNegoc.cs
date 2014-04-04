using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MundoDaFoto.Dominio;

namespace GetEmpresa.Negoc.Interface
{
    public interface IClientNegoc
    {
        IList<Client> BuscarTodos();
        Client BuscarPorId(long id);
        void Incluir(ref Client _Client);
        void Alterar(ref Client _Client);
        void Excluir(ref Client _Client);
    }
}
