using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericFrameworkNhibernate
{
    public interface IDao<TEntity>
    {
        TEntity Capturar(long id);

        IList<TEntity> BuscarTodos();

        void Incluir(ref TEntity entity);

        void Alterar(ref TEntity entity);

        void Deletar(ref TEntity entity);
    }
}
