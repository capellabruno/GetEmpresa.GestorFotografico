using System;
using MundoDaFoto.Domain;
using GetEmpresa.Dao.Interface;
using GenericFrameworkNhibernate;
using MundoDaFoto.Domain.Photographer;
using NHibernate;
using NHibernate.Criterion;
using System.Collections.Generic;

namespace GetEmpresa.Dao.Implementation{
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
