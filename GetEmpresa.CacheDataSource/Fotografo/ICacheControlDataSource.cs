using System;
using System.Collections.Generic;
using System.Data;
namespace GetEmpresa.CacheDataSource.Fotografo
{
    public interface ICacheControlDataSource
    {
        void CreateCacheDataSource();
        void UpdateCacheControl(ref System.Data.DataSet ds);
        DataTable GetTableCache(string _tableName);
        DataRow BuscarPorCodigo(long _codigo, string _tableName);
        DataRow BuscarPorCodigo(string _codigo, string _tableName);
        DataRow BuscarPorCodigo(decimal _codigo, string _tableName);
        DataRow BuscarPorCodigo(int _codigo, string _tableName);
        DataRow[] BuscarPorNomeLike(string _nome, string _tableName);
        DataRow[] BuscarPorLike(IList<CacheControlDomain> _paramSearch, string _tableName);        
    }
}
