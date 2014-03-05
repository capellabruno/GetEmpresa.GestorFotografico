using System;
namespace GetEmpresa.CacheDataSource.Fotografo
{
    public interface ICacheConnection
    {
        System.Collections.Generic.List<string> ExistsModificateData();
        System.Data.DataTable[] GetAllData();
        System.Data.DataTable GetData(string _tableName);
        void SetUpdateDataOnUpdate(string _tableName);
        void InsertControlDataOnUpdate(string _tableName);
    }
}
