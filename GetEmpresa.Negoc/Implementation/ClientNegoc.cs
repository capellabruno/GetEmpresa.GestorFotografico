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
    public class ClientNegoc : IClientNegoc
    {

        private IClientDao _ClientDao;
        public IClientDao ClientDao
        {
            get { return _ClientDao; }
            set { _ClientDao = value; }
        }

        /*****************************************************************************************************/

        [Transaction(ReadOnly=true)]
        public IList<Client> BuscarTodos()
        {
            return this.ClientDao.BuscarTodos();
        }

        [Transaction(ReadOnly = true)]
        public Client BuscarPorId(long id)
        {
            if (id == 0)
                throw new Exception("Codigo do Client não foi informado");

            return this.ClientDao.Capturar(id);

        }

        [Transaction(Spring.Transaction.TransactionPropagation.Required)]
        public void Incluir(ref Client _Client)
        {
            if (_Client == null)
                throw new Exception("Client não informado");

            this.VerificarSeClientExiste(_Client);

            this.ClientDao.Incluir(ref _Client);
        }

        [Transaction(ReadOnly = true)]
        private void VerificarSeClientExiste(Client _Client)
        {
            if (this.ClientDao.BuscarClientPorEmail(_Client.Email) != null)
                throw new Exception("E-mail informado para cadastro já existe");

            if (this.ClientDao.BuscarClientPorNome(_Client.Name) != null)
                throw new Exception("Já existe um cadastro de Client com este Nome");

        }

        [Transaction(Spring.Transaction.TransactionPropagation.Required)]
        public void Alterar(ref Client _Client)
        {
            if (_Client == null)
                throw new Exception("Client não foi informado");

            if (_Client.Id == 0)
                throw new Exception("Não é possivel alterar um Client não Serializavel");

            this.ClientDao.Alterar(ref _Client);

        }

        [Transaction(Spring.Transaction.TransactionPropagation.Required)]
        public void Excluir(ref Client _Client)
        {
            if (_Client == null)
                throw new Exception("Client não foi informado");

            if (_Client.Id == 0)
                throw new Exception("Não é possivel localizar o Client");

            _Client.Active = false;

            this.ClientDao.Alterar(ref _Client);
        }

    }
}
