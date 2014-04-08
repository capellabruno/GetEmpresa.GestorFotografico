using System;
using GetEmpresa.Dao.Interface;
using GenericFrameworkNhibernate;
using MundoDaFoto.Domain;
using NHibernate.Criterion;
using NHibernate;

namespace GetEmpresa.Dao.Implementation{
    public class CountryDao :GenericDao<Country> , ICountryDao{
        public Country Get(string nome) {
            ICriteria criteria = base.CurrentSession
                .CreateCriteria(typeof(Country))
                .Add(Expression.Eq("Acronym", nome));
            return criteria.UniqueResult<Country>();
        }
    }
}
