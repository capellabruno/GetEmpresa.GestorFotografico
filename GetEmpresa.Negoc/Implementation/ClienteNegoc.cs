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
    public class ClienteNegoc : IClienteNegoc
    {

        private IClienteDao _clienteDao;
        public IClienteDao ClienteDao
        {
            get { return _clienteDao; }
            set { _clienteDao = value; }
        }

        /*****************************************************************************************************/

        [Transaction(ReadOnly=true)]
        public IList<Cliente> BuscarTodos()
        {
            return this.ClienteDao.BuscarTodos();
        }

        [Transaction(ReadOnly = true)]
        public Cliente BuscarPorId(long id)
        {
            if (id == 0)
                throw new Exception("Codigo do CLiente não foi informado");

            return this.ClienteDao.Capturar(id);

        }

        [Transaction(Spring.Transaction.TransactionPropagation.Required)]
        public void Incluir(ref Cliente _cliente)
        {
            if (_cliente == null)
                throw new Exception("Cliente não informado");

            this.VerificarSeClienteExiste(_cliente);

            this.ClienteDao.Incluir(ref _cliente);
        }

        [Transaction(ReadOnly = true)]
        private void VerificarSeClienteExiste(Cliente _cliente)
        {
            if (this.ClienteDao.BuscarClientePorEmail(_cliente.Email) != null)
                throw new Exception("E-mail informado para cadastro já existe");

            if (this.ClienteDao.BuscarClientePorNome(_cliente.Nome) != null)
                throw new Exception("Já existe um cadastro de cliente com este Nome");

        }

        [Transaction(Spring.Transaction.TransactionPropagation.Required)]
        public void Alterar(ref Cliente _cliente)
        {
            if (_cliente == null)
                throw new Exception("Cliente não foi informado");

            if (_cliente.Id == 0)
                throw new Exception("Não é possivel alterar um cliente não Serializavel");

            this.ClienteDao.Alterar(ref _cliente);

        }

        [Transaction(Spring.Transaction.TransactionPropagation.Required)]
        public void Excluir(ref Cliente _cliente)
        {
            if (_cliente == null)
                throw new Exception("Cliente não foi informado");

            if (_cliente.Id == 0)
                throw new Exception("Não é possivel localizar o cliente");

            _cliente.Ativo = false;

            this.ClienteDao.Alterar(ref _cliente);
        }

    }
}
