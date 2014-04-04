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
    public class CityNegoc : ICityNegoc
    {

        private ICityDao _CityDao;

        public ICityDao CityDao
        {
            get { return _CityDao; }
            set { _CityDao = value; }
        }


        /*************************************************************************************************************/
        [Transaction(ReadOnly = true)]
        public IList<City> BuscarTodos(long idState)
        {
            IList<City> _todas;

            _todas = this.CityDao.BuscarTodos();

            _todas = (from a in _todas where a.Uf.Id == idState select a).ToList();

            return _todas;
        }

        [Transaction(ReadOnly = true)]
        public City BuscarPorId(long idCity)
        {
            return this.CityDao.Capturar(idCity);
        }
    }
}
