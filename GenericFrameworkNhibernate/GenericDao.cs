using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Spring.Transaction.Interceptor;
using NHibernate;

namespace GenericFrameworkNhibernate{
    public abstract class GenericDao<T> : NHbernateDao, IGenericDao<T> where T : class{
        public T Get(long id){
            return base.CurrentSession.Get<T>(id);
        }

        public IList<T> GetAll() {
            ICriteria criteria = CurrentSession.CreateCriteria<T>();
            return criteria.List<T>();
        }

        public void Add(T entity){
            if (!base.SessionFactory.IsClosed)
                base.CurrentSession.Save(entity);
        }

        public void Update(T entity){
            base.CurrentSession.SaveOrUpdate(entity);
        }

        public void Remove(T entity){
            base.CurrentSession.Delete(entity);
        }

    }// class
}
