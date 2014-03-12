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

        private static DataSet _dataSource;

        public static DataSet CacheApplicationDataSource
        {
            get {
                return _dataSource; 
            }
            set
            {
                _dataSource = value;
            }
        }

        public void CreateCacheDataSource()
        {
   
            DataSet ds = null;
            DataTable[] _dts;
            if (HttpContext.Current != null)
            {
                if (CacheApplicationDataSource != null)
                {
                    ds = (DataSet)CacheApplicationDataSource;
                }
                else
                {
                    ds = new DataSet();
                    _dts = this.CacheConnection.GetAllData();
                    ds.Tables.AddRange(_dts);
                }

               CacheApplicationDataSource = ds;
            }
        }

        
    }
}
