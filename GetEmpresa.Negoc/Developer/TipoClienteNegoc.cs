
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GetEmpresa.Negoc.Interface;
using GetEmpresa.Dao.Interface;
using MundoDaFoto.Dominio;
using Spring.Transaction.Interceptor;


namespace GetEmpresa.Negoc.Developer
{
    public class TipoClientNegoc : ITipoClientNegoc
    {

        private ITipoClientDao _tipoClientDao;

        public ITipoClientDao TipoClientDao
        {
            get { return _tipoClientDao; }
            set { _tipoClientDao = value; }
        }


        /*****************************************************************************************************/

        [Transaction(ReadOnly = true)]
        public IList<MundoDaFoto.Dominio.TipoClient> BuscarTodos()
        {
            return this.TipoClientDao.BuscarTodos();
        }

        [Transaction(ReadOnly = true)]
        public MundoDaFoto.Dominio.TipoClient BuscarPorId(long id)
        {
            return this.TipoClientDao.Capturar(id);
        }
    }
}
