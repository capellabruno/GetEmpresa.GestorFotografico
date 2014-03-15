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
    public class PaisNegoc: IPaisNegoc
    {

        private IPaisDao _paisDao;
        public IPaisDao PaisDao
        {
            get { return _paisDao; }
            set { _paisDao = value; }
        }


         /*****************************************************************************************************/
        [Transaction(ReadOnly = true)]
        public IList<Pais> BuscarTodos()
        {
            return this.PaisDao.BuscarTodos();
        }

        [Transaction(ReadOnly = true)]
        public Pais BuscarPorId(long Pais)
        {
            return this.PaisDao.Capturar(Pais);
        }
    }
}
