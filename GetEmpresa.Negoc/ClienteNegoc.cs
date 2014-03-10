using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spring.Transaction.Interceptor;
using NHibernate;
using GetEmpresa.CacheDataSource.Fotografo;
using GetEmpresa.GestorFotografico.Domain;
using GetEmpresa.Dao;
using GenericFrameworkNhibernate;
using GetEmpresa.Payment;
using System.Data;


namespace GetEmpresa.Negoc
{
    public class ClienteNegoc : GetEmpresa.Negoc.IClienteNegoc
    {
        #region "Classes Injetaveis"
        private Dao.Interface.IClienteDao _clienteDao;

        public Dao.Interface.IClienteDao ClienteDao
        {
            get { return _clienteDao; }
            set { _clienteDao = value; }
        }

        private Dao.Interface.IClientePortalDao _clientePortal;

        public Dao.Interface.IClientePortalDao ClientePortalDao
        {
            get { return _clientePortal; }
            set { _clientePortal = value; }
        }

        private ICacheControlDataSource _cacheControlDataSource = new CacheControlDataSource();

        public ICacheControlDataSource CacheControlDataSource
        {
            get { return _cacheControlDataSource; }
            set { _cacheControlDataSource = value; }
        }

        private Dao.Interface.IConfigurationSystemDao _configurationSystemDao;

        public Dao.Interface.IConfigurationSystemDao ConfigurationSystemDao
        {
            get { return _configurationSystemDao; }
            set { _configurationSystemDao = value; }
        }


        #endregion

        private string _tableCache = "PessoaPortal";

        [Transaction(ReadOnly = false)]
        public void IncluirClienteFotografo(ref GestorFotografico.Domain.Cliente.Cliente _cliente)
        {
            if (_cliente.ClientePai == null)
            {
                throw new Exception("Cliente responsavel não foi informado");
            }

            this.ClienteDao.Incluir(ref _cliente);

        }

        [Transaction(Spring.Transaction.TransactionPropagation.Required)]
        public void IncluirClientePortal(ref GestorFotografico.Domain.Gerencial.ClientePortal _cliente)
        {
            GestorFotografico.Domain.Gerencial.ClientePortal _nCliente = _cliente;
            GestorFotografico.Domain.Gerencial.ConfigurationSystem _config = _cliente.Configuration;
            if (_cliente == null)
            {
                throw new Exception("Cliente não foi informado");
            }

            this.ClientePortalDao.Incluir(ref _nCliente);

            this.ConfigurationSystemDao.Incluir(ref _config);

            if (_nCliente.Id > 0 && _config.Id > 0)
                _cliente = _nCliente;
            else
                throw new Exception("Não foi possivel incluir o cadastro");
        }

        public GestorFotografico.Domain.Cliente.Cliente BuscarClienteFotografoPorID(long _codigo) {
            DataRow _row;

            return null;
        }

        public IList<GestorFotografico.Domain.Cliente.Cliente> BuscarClienteFotografoPorNomeLike(string _nome)
        {
            DataRow _rows;

            return null;
        }

        public IList<GestorFotografico.Domain.Cliente.Cliente> BuscarTodosOsClientesPorClientePortal(GetEmpresa.GestorFotografico.Domain.Gerencial.ClientePortal _clientePortal) {
            return null;
        }

        public GestorFotografico.Domain.Gerencial.ConfigurationSystem GetConfigurarion(string _email)
        {
            DataRow[] _row;
            GestorFotografico.Domain.Gerencial.ConfigurationSystem _return;
            List<GestorFotografico.Domain.Gerencial.ConfigurationSystem> _configs;
            GestorFotografico.Domain.Gerencial.ClientePortal _cliente;
            List<GestorFotografico.Domain.Gerencial.ClientePortal> _clientes;

            IList<CacheControlDomain> _listaSearch = new List<CacheControlDomain>();

            _listaSearch.Add(new CacheControlDomain() { Column = "Email", Value = _email });

            _row = this.CacheControlDataSource.BuscarPorLike(_listaSearch, "pessoaportal");

            if (_row.Length > 0)
            {
                _clientes = new List<GestorFotografico.Domain.Gerencial.ClientePortal>();

                Transcritor.Transcreve(_row, _clientes);
                _cliente = _clientes.FirstOrDefault();

                long codigoCliente = Convert.ToInt64(_cliente.Id);
                
                _listaSearch = new List<CacheControlDomain>();
                
                _listaSearch.Add(new CacheControlDomain() { Column = "PessoaPortal_IdPessoaPortal", Value = codigoCliente.ToString() });
                
                _row = null;

                _row = this.CacheControlDataSource.BuscarPorLike(_listaSearch, "pessoaportal");

                if (_row.Length > 0)
                {
                    _configs = new List<GestorFotografico.Domain.Gerencial.ConfigurationSystem>();
                    Transcritor.Transcreve(_row, _configs);
                    _return = _configs.FirstOrDefault();
                }
            }
            return new GestorFotografico.Domain.Gerencial.ConfigurationSystem();
        }

    }
}
