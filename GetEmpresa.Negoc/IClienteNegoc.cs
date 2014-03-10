using System;
namespace GetEmpresa.Negoc
{
    public interface IClienteNegoc
    {
        GetEmpresa.GestorFotografico.Domain.Cliente.Cliente BuscarClienteFotografoPorID(long _codigo);
        System.Collections.Generic.IList<GetEmpresa.GestorFotografico.Domain.Cliente.Cliente> BuscarClienteFotografoPorNomeLike(string _nome);
        System.Collections.Generic.IList<GetEmpresa.GestorFotografico.Domain.Cliente.Cliente> BuscarTodosOsClientesPorClientePortal(GetEmpresa.GestorFotografico.Domain.Gerencial.ClientePortal _clientePortal);
        GetEmpresa.CacheDataSource.Fotografo.ICacheControlDataSource CacheControlDataSource { get; set; }
        void IncluirClienteFotografo(ref GetEmpresa.GestorFotografico.Domain.Cliente.Cliente _cliente);
        void IncluirClientePortal(ref GetEmpresa.GestorFotografico.Domain.Gerencial.ClientePortal _cliente);
        GetEmpresa.GestorFotografico.Domain.Gerencial.ConfigurationSystem GetConfigurarion(string _email);
    }
}
