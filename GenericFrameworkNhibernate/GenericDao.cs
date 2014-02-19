using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Spring.Transaction.Interceptor;

namespace GenericFrameworkNhibernate
{
    public abstract class GenericDao<T> : NHbernateDao, IGenericDao<T> where T : class
    {

        [Transaction(ReadOnly = true)]
        public T Capturar(long id)
        {
            return base.CurrentSession.Get<T>(id);
        }

        [Transaction(ReadOnly = true)]
        public IList<T> BuscarTodos()
        {
            return base.GetAll<T>();
        }

        [Transaction(ReadOnly = false)]
        public void Incluir(ref T entity)
        {
            if (!base.SessionFactory.IsClosed)
                base.CurrentSession.Save(entity);
        }

        [Transaction(ReadOnly = false)]
        public void Alterar(ref T entity)
        {
            base.CurrentSession.SaveOrUpdate(entity);
        }

        [Transaction(ReadOnly = false)]
        public void Deletar(ref T entity)
        {
            base.CurrentSession.Delete(entity);
        }
    }
}
