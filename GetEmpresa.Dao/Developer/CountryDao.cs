using System;
using GetEmpresa.Dao.Interface;
using GenericFrameworkNhibernate;
using MundoDaFoto.Dominio;
using NHibernate.Criterion;
using NHibernate;

namespace GetEmpresa.Dao.Developer{
    public class CountryDao :GenericDao<Country> , ICountryDao{
        public Country Get(string nome) {
            ICriteria criteria = base.CurrentSession
                .CreateCriteria(typeof(Country))
                .Add(Expression.Eq("Acronym", nome));
            return criteria.UniqueResult<Country>();
        }
    }
}
