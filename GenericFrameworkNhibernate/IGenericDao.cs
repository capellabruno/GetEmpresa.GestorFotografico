using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericFrameworkNhibernate{
    public interface IGenericDao<T> {
        T Get(long id);
        IList<T> GetAll();
        void Add(T entity);
        void Update(T entity);
        void Remove(T entity);
    } // class
}
