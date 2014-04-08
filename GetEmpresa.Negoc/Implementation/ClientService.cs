using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GetEmpresa.Negoc.Interface;
using GetEmpresa.Dao.Interface;
using MundoDaFoto.Domain;
using Spring.Transaction.Interceptor;

namespace GetEmpresa.Negoc.Implementation{
    public class ClientService : IClientService{
        private IClientDao _clientDao;
        public ClientService(IClientDao clientDao) {
            _clientDao = clientDao;
        }


        [Transaction(ReadOnly=true)]
        public IList<Client> GetAll() {
            return _clientDao.GetAll();
        }

        [Transaction(ReadOnly = true)]
        public Client GetById(long id){
            if (id == 0)
                throw new InvalidOperationException("Codigo do Client não foi informado");

            return _clientDao.Get(id);
        }

        [Transaction(Spring.Transaction.TransactionPropagation.Required)]
        public void Add(Client client){
            if (client == null)
                throw new ArgumentNullException("client","Client não informado");

            VerifyIfClientExists(client);
            _clientDao.Add(client);
        }

        [Transaction(ReadOnly = true)]
        private void VerifyIfClientExists(Client client){
            if (_clientDao.BuscarClientPorEmail(client.Email) != null)
                throw new Exception("E-mail informado para cadastro já existe");

            if (_clientDao.BuscarClientPorNome(client.Name) != null)
                throw new Exception("Já existe um cadastro de Client com este Nome");
        }

        [Transaction(Spring.Transaction.TransactionPropagation.Required)]
        public void Update(Client _client){
            if (_client == null)
                throw new ArgumentNullException("_client","Client não foi informado");

            if (_client.Id == 0)
                throw new Exception("Não é possivel alterar um Client não Serializavel");

            _clientDao.Update(_client);
        }

        [Transaction(Spring.Transaction.TransactionPropagation.Required)]
        public void Remove(Client _client){
            if (_client == null)
                throw new ArgumentNullException("_client","Client não foi informado");

            if (_client.Id == 0)
                throw new Exception("Não é possivel localizar o Client");

            _client.Active = false;
            _clientDao.Update(_client);
        }
    }// class
}
