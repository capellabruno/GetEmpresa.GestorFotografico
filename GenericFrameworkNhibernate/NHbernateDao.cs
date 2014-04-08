using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate;

namespace GenericFrameworkNhibernate{
    public abstract class NHbernateDao{
        private ISessionFactory sessionFactory;

        public ISessionFactory SessionFactory{
            protected get{
                return sessionFactory;
            }
            set { sessionFactory = value; }
        }

        protected ISession CurrentSession{
            get{
                return SessionFactory.GetCurrentSession();
            }
        }
    }// class
}
