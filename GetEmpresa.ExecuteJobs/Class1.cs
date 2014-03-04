using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetEmpresa.ExecuteJobs
{
    public class JobCacheControler
    {
        private static GetEmpresa.CacheDataSource.Fotografo.ICacheControlDataSource _cacheControlDataSource = new GetEmpresa.CacheDataSource.Fotografo.CacheControlDataSource();

        public static GetEmpresa.CacheDataSource.Fotografo.ICacheControlDataSource CacheControlDataSource
        {
            get { return _cacheControlDataSource; }
            set { _cacheControlDataSource = value; }
        }

        public static void UpdateCacheControler()
        {
            CacheControlDataSource.CreateCacheDataSource();
        }
    }
}
