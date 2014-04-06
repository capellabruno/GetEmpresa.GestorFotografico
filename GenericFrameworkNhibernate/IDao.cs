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

        void Incluir(TEntity entity);

        void Alterar(TEntity entity);

        void Deletar(TEntity entity);
    }
}
