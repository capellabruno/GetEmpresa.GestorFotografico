using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MundoDaFoto.Dominio;

namespace GetEmpresa.Negoc.Interface
{
    public interface IClienteNegoc
    {
        IList<Cliente> BuscarTodos();
        Cliente BuscarPorId(long id);
        void Incluir(ref Cliente _cliente);
        void Alterar(ref Cliente _cliente);
        void Excluir(ref Cliente _cliente);
    }
}
