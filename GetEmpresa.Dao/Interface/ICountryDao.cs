using System;
using GenericFrameworkNhibernate;
using MundoDaFoto.Dominio;


namespace GetEmpresa.Dao.Interface{
    public interface ICountryDao : IGenericDao<Country>{
        Country Get(string nome);
    }
}
