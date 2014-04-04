
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GetEmpresa.Negoc.Interface;
using GetEmpresa.Dao.Interface;
using MundoDaFoto.Dominio;
using Spring.Transaction.Interceptor;


namespace GetEmpresa.Negoc.Implementation
{
    public class TipoClienteNegoc : ITipoClienteNegoc
    {

        private ITipoClienteDao _tipoClienteDao;

        public ITipoClienteDao TipoClienteDao
        {
            get { return _tipoClienteDao; }
            set { _tipoClienteDao = value; }
        }


        /*****************************************************************************************************/

        [Transaction(ReadOnly = true)]
        public IList<MundoDaFoto.Dominio.TipoCliente> BuscarTodos()
        {
            return this.TipoClienteDao.BuscarTodos();
        }

        [Transaction(ReadOnly = true)]
        public MundoDaFoto.Dominio.TipoCliente BuscarPorId(long id)
        {
            return this.TipoClienteDao.Capturar(id);
        }
    }
}
