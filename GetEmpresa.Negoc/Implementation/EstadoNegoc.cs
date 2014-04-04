using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GetEmpresa.Negoc.Interface;
using GetEmpresa.Dao.Interface;
using MundoDaFoto.Dominio;
using Spring.Transaction.Interceptor;

namespace GetEmpresa.Negoc.Implementation
{
    public class EstadoNegoc : IEstadoNegoc
    {
        private IEstadoDao _estadoDao;

        public IEstadoDao EstadoDao
        {
            get { return _estadoDao; }
            set { _estadoDao = value; }
        }

        /*****************************************************************************************************/
        [Transaction(ReadOnly = true)]
        public IList<Estado> BuscarTodos(long _idPais)
        {
            IList<Estado> _lista;

            _lista = this.EstadoDao.BuscarTodos();

            _lista = (from a in _lista where a.Pais.Id == _idPais select a).ToList();

            return _lista;
        }

        [Transaction(ReadOnly = true)]
        public Estado BuscarPorId(long idEstado)
        {
            return this.EstadoDao.Capturar(idEstado);
        }
    }
}
