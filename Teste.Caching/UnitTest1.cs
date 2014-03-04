using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Teste.Caching
{
    [TestClass]
    public class TesteCacheControlDataSource
    {

        private GetEmpresa.CacheDataSource.Fotografo.ICacheControlDataSource _cacheControlDataSource = new GetEmpresa.CacheDataSource.Fotografo.CacheControlDataSource();

        public GetEmpresa.CacheDataSource.Fotografo.ICacheControlDataSource CacheControlDataSource
        {
            get { return _cacheControlDataSource; }
            set { _cacheControlDataSource = value; }
        }


        [TestMethod]
        public void CreateCacheDataSource()
        {
            this.CacheControlDataSource.CreateCacheDataSource();
        }

        [TestMethod]
        public void GetTableCache()
        {
        }


    }
}
