using System;
using MundoDaFoto.Dominio;
using GetEmpresa.Dao.Interface;
using GenericFrameworkNhibernate;
using MundoDaFoto.Dominio.Photographer;
using NHibernate;
using NHibernate.Criterion;
using System.Collections.Generic;

namespace GetEmpresa.Dao.Developer{
    public class PhotographerProfileDao : GenericDao<PhotographerProfile>, IPhotographerProfileDao {

        public long RowCount(string _email) {
            ICriteria criteria = base.CurrentSession
                .CreateCriteria(typeof(PhotographerProfile))
                .Add(Restrictions.Eq("Email", _email))
                .SetProjection(
                    Projections.Count(Projections.Id())
                );

            var count = criteria.UniqueResult<long>();
            return count;   
        }

        public PhotographerProfile Get(string _email) {
            ICriteria criteria = base.CurrentSession
                .CreateCriteria(typeof(PhotographerProfile))
                .Add(Restrictions.Eq("Email", _email));

            return criteria.UniqueResult<PhotographerProfile>();
        }

    }// class
}
