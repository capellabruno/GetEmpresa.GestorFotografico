using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;
using System.Collections.Generic;
using System.Data;

namespace Teste.Caching
{
    [TestClass]
    public class TesteCacheConnection
    {
        private GetEmpresa.CacheDataSource.Fotografo.ICacheConnection _cacheConnection = new GetEmpresa.CacheDataSource.Fotografo.CacheConnection();

        public GetEmpresa.CacheDataSource.Fotografo.ICacheConnection CacheConnection
        {
            get { return _cacheConnection; }
            set { _cacheConnection = value; }
        }

        [TestMethod]
        public void ExistsModificateData()
        {
            List<string> _list = null;
            _list = this.CacheConnection.ExistsModificateData();
            Assert.IsTrue(_list != null && _list.Count > 0);
        }

        [TestMethod]
        public void GetAllData()
        {
            DataTable[] _tables;
            _tables = this.CacheConnection.GetAllData();

            Assert.IsTrue(_tables != null && _tables.Length > 0);
        }

        [TestMethod]
        public void GetData()
        {          
            DataTable _dt;

            List<string> _list = null;
            _list = this.CacheConnection.ExistsModificateData();

            _dt = this.CacheConnection.GetData(_list[0]);

            Assert.IsTrue(_dt != null && _dt.Rows.Count > 0);

        }

        [TestMethod]
        public void SetUpdateDataOnUpdate()
        {
            List<string> _list = null;
            _list = this.CacheConnection.ExistsModificateData();

            this.CacheConnection.SetUpdateDataOnUpdate(_list[0]);

            Assert.IsTrue(true);

        }

    }
}
