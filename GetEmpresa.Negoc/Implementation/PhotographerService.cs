using GetEmpresa.Dao.Interface;
using GetEmpresa.Negoc.Interface;
using MundoDaFoto.Dominio.Photographer;
using Spring.Transaction.Interceptor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MundoDaFoto.Dominio;

namespace GetEmpresa.Negoc.Implementation {
    public class PhotographerService : IPhotographerService{

        private IPhotographerProfileDao _photographerProfileDao;
        private ICountryDao _countryDao;
        private IPhotographerProfileDao _fotografoDao;
        public PhotographerService(IPhotographerProfileDao photographerProfileDao, ICountryDao countryDao, IPhotographerProfileDao fotografoDao) {
            _photographerProfileDao = photographerProfileDao;
            _countryDao = countryDao;
            _fotografoDao = fotografoDao;
        }

        [Transaction(ReadOnly = true)]
        public bool HasProfile(string _email) {
            return _photographerProfileDao.RowCount(_email) > 0;
        }

        [Transaction(ReadOnly = true)]
        public PhotographerProfile GetProfile(string _email) {
            var photographerProfile = _photographerProfileDao.Get(_email);

            return photographerProfile ?? new NullPhotographerProfile();
        }

        [Transaction]
        public void CreateNewProfile(PhotographerProfile profile) {
            if (!profile.IsValid())
                throw new Exception();
            _photographerProfileDao.Incluir(profile);
        }
    }// class
}
