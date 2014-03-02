using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Teste.Caching
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            GetEmpresa.CacheDataSource.Fotografo.LoadCache.Sync();
        }
    }
}
