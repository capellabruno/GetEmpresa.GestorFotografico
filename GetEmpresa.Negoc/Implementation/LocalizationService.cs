using GetEmpresa.Dao.Interface;
using GetEmpresa.Negoc.Interface;
using MundoDaFoto.Domain;
using Spring.Transaction.Interceptor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetEmpresa.Negoc.Implementation {
    public class LocalizationService : ILocalizationService {
        private ICityDao _cityDao;
        private ICountryDao _countryDao;
        private IStateDao _stateDao;
        public LocalizationService(ICountryDao countryDao, IStateDao stateDao, ICityDao cityDao) {
            _countryDao = countryDao;
            _stateDao = stateDao;
            _cityDao = cityDao;
        }

        [Transaction(ReadOnly = true)]
        public IList<Country> GetCountries() {
            return _countryDao.GetAll();
        }

        [Transaction(ReadOnly = true)]
        public Country GetCountryById(long countryId) {
            return _countryDao.Get(countryId);
        }
    }// class
}
