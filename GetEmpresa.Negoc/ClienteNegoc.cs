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

        private string _tableCache = "ClientePortal";

        [Transaction(ReadOnly = false)]
        public void IncluirClienteFotografo(ref GestorFotografico.Domain.Cliente.Cliente _cliente)
        {
            if (_cliente.ClientePai == null)
            {
                throw new Exception("Cliente responsavel não foi informado");
            }

            this.ClienteDao.Incluir(ref _cliente);

            this.CacheControlDataSource.InsertControlCacheUpdate(_tableCache);
        }

        [Transaction(ReadOnly = false)]
        public void IncluirClientePortal(ref GestorFotografico.Domain.Gerencial.ClientePortal _cliente)
        {
            GestorFotografico.Domain.Gerencial.ClientePortal _nCliente = _cliente;
            if (_cliente == null)
            {
                throw new Exception("Cliente não foi informado");
            }

            this.ClientePortalDao.Incluir(ref _nCliente);

            _cliente = _nCliente;
            
            this.CacheControlDataSource.InsertControlCacheUpdate(_tableCache);

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
    }
}
