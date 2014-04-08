using MundoDaFoto.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetEmpresa.Negoc.Interface {
    public interface ILocalizationService {
        IList<Country> GetCountries();
        Country GetCountryById(long countryId);
    } // class
}
