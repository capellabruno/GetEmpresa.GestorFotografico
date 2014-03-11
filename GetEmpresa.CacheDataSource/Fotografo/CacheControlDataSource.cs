using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Caching;
using System.Web.UI;
using System.Web.Util;
using System.Web;
using System.Web.UI.WebControls;
using System.Data;
using Spring;
using Spring.Context;
using Spring.Context.Support;


namespace GetEmpresa.CacheDataSource.Fotografo
{
    public class CacheControlDataSource : GetEmpresa.CacheDataSource.Fotografo.ICacheControlDataSource
    {

        private ICacheConnection _cacheConnection = new CacheConnection();

        public ICacheConnection CacheConnection
        {
            get { return _cacheConnection; }
            set { _cacheConnection = value; }
        }

        private DataSet _dataSource;

        public DataSet CacheApplicationDataSource
        {
            get {
                if (HttpContext.Current != null && HttpContext.Current.Application["DataSourceBaseCurrentContext"] != null)
                {
                    _dataSource = (DataSet)HttpContext.Current.Application["DataSourceBaseCurrentContext"];
                }

                return _dataSource; 
            }
        }

        public void CreateCacheDataSource()
        {
   
            DataSet ds = null;
            DataTable[] _dts;
            if (HttpContext.Current != null)
            {
                if (HttpContext.Current.Application["DataSourceBaseCurrentContext"] != null)
                {
                    ds = (DataSet)HttpContext.Current.Application["DataSourceBaseCurrentContext"];
                }
                else
                {
                    ds = new DataSet();
                    _dts = this.CacheConnection.GetAllData();
                    ds.Tables.AddRange(_dts);
                }

                this.UpdateCacheControl(ref ds);

                HttpContext.Current.Application["DataSourceBaseCurrentContext"] = ds;
            }
        }

        public void UpdateCacheControl(ref DataSet ds)
        {
            List<string> _tablesNamesUpdate;

            _tablesNamesUpdate = this.CacheConnection.ExistsModificateData();

            if (_tablesNamesUpdate != null && _tablesNamesUpdate.Count > 0)
            {
                foreach (string item in _tablesNamesUpdate)
                {
                    ds.Tables.Remove(item);
                    DataTable dt = this.CacheConnection.GetData(item);
                    ds.Tables.Add(dt);
                    this.CacheConnection.SetUpdateDataOnUpdate(item);
                }
            }

        }

        public DataTable GetTableCache(string _tableName)
        {
            DataSet ds = null;
            DataTable _dt;          
            ds = (DataSet)HttpContext.Current.Application["DataSourceBaseCurrentContext"];

            _dt = ds.Tables[_tableName];
            return _dt;
        }

        private void NecessaryUpdate()
        {
            DataSet ds = this.CacheApplicationDataSource;
            this.UpdateCacheControl(ref ds);
            HttpContext.Current.Application["DataSourceBaseCurrentContext"] = ds;
        }

        public DataRow BuscarPorCodigo(long _codigo, string _tableName)
        {
            this.NecessaryUpdate();

            throw new NotImplementedException();
        }

        public DataRow BuscarPorCodigo(string _codigo, string _tableName)
        {
            this.NecessaryUpdate();

            throw new NotImplementedException();
        }

        public DataRow BuscarPorCodigo(decimal _codigo, string _tableName)
        {
            this.NecessaryUpdate();

            throw new NotImplementedException();
        }

        public DataRow BuscarPorCodigo(int _codigo, string _tableName)
        {
            this.NecessaryUpdate();

            throw new NotImplementedException();
        }

        public DataRow[] BuscarPorNomeLike(string _nome, string _tableName)
        {
            this.NecessaryUpdate();

            throw new NotImplementedException();
        }

        public DataRow[] BuscarPorLike(IList<CacheControlDomain> _paramSearch, string _tableName)
        {
            this.NecessaryUpdate();

            
            if (_paramSearch == null || _paramSearch.Count == 0)
                throw new Exception("Parametro do consulta não foi informado");
            
            DataTable _dt = this.CacheApplicationDataSource.Tables[_tableName];
            
            DataRow[] _rows = null;
            
            string _expression = string.Empty;    
            
            if (_dt == null)
                throw new Exception("Não foi possivel localizar o dado solicitado");
            
            foreach(CacheControlDomain item in _paramSearch){
                if(String.IsNullOrEmpty(_expression)){
                    _expression = item.Column  + " = '" + item.Value + "'";
                }else{
                    _expression = " and " + item.Column  + " = '" + item.Value + "'";
                }
            }
            
            _rows = _dt.Select(_expression);
            
            return _rows;
        }


        public void InsertControlCacheUpdate(string _tableName)
        {
            this.CacheConnection.InsertControlDataOnUpdate(_tableName);
        }
    }
}
