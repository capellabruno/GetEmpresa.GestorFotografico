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
    public class CountryNegoc: ICountryNegoc
    {

        private ICountryDao _CountryDao;
        public ICountryDao CountryDao
        {
            get { return _CountryDao; }
            set { _CountryDao = value; }
        }


         /*****************************************************************************************************/
        [Transaction(ReadOnly = true)]
        public IList<Country> BuscarTodos()
        {
            return this.CountryDao.BuscarTodos();
        }

        [Transaction(ReadOnly = true)]
        public Country BuscarPorId(long Country)
        {
            return this.CountryDao.Capturar(Country);
        }
    }
}
