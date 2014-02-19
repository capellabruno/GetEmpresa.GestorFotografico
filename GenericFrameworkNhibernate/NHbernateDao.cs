using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate;
using Spring.Transaction.Interceptor;

namespace GenericFrameworkNhibernate
{
    public abstract class NHbernateDao
    {
        private ISessionFactory sessionFactory;

        public ISessionFactory SessionFactory
        {
            protected get
            {
                return sessionFactory;
            }
            set { sessionFactory = value; }
        }

        protected ISession CurrentSession
        {
            get
            {
                return SessionFactory.GetCurrentSession();
            }
        }

        protected IList<T> GetAll<T>() where T : class
        {
            ICriteria criteria = CurrentSession.CreateCriteria<T>();
            return criteria.List<T>();
        }

    }
}
