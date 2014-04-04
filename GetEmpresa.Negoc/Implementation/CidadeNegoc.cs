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
    public class CidadeNegoc : ICidadeNegoc
    {

        private ICidadeDao _cidadeDao;

        public ICidadeDao CidadeDao
        {
            get { return _cidadeDao; }
            set { _cidadeDao = value; }
        }


        /*************************************************************************************************************/
        [Transaction(ReadOnly = true)]
        public IList<Cidade> BuscarTodos(long idEstado)
        {
            IList<Cidade> _todas;

            _todas = this.CidadeDao.BuscarTodos();

            _todas = (from a in _todas where a.Uf.Id == idEstado select a).ToList();

            return _todas;
        }

        [Transaction(ReadOnly = true)]
        public Cidade BuscarPorId(long idCidade)
        {
            return this.CidadeDao.Capturar(idCidade);
        }
    }
}
