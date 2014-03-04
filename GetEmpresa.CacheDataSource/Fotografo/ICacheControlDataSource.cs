using System;
using System.Data;
namespace GetEmpresa.CacheDataSource.Fotografo
{
    public interface ICacheControlDataSource
    {
        void CreateCacheDataSource();
        void UpdateCacheControl(ref System.Data.DataSet ds);
        DataTable GetTableCache(string _tableName);
    }
}
