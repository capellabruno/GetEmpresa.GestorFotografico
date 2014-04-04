using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GetEmpresa.Negoc.Interface;
using GetEmpresa.Dao.Interface;
using MundoDaFoto.Dominio;
using Spring.Transaction.Interceptor;

namespace GetEmpresa.Negoc.Developer
{
    public class StateNegoc : IStateNegoc
    {
        private IStateDao _StateDao;

        public IStateDao StateDao
        {
            get { return _StateDao; }
            set { _StateDao = value; }
        }

        /*****************************************************************************************************/
        [Transaction(ReadOnly = true)]
        public IList<State> BuscarTodos(long _idCountry)
        {
            IList<State> _lista;

            _lista = this.StateDao.BuscarTodos();

            _lista = (from a in _lista where a.Country.Id == _idCountry select a).ToList();

            return _lista;
        }

        [Transaction(ReadOnly = true)]
        public State BuscarPorId(long idState)
        {
            return this.StateDao.Capturar(idState);
        }
    }
}
