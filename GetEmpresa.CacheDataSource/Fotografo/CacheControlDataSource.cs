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

        public void CreateCacheDataSource()
        {

            DataSet ds = null;
            DataTable[] _dts;          

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

    }
}
