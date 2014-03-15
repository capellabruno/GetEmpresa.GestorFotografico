using System;
using GenericFrameworkNhibernate;
using MundoDaFoto.Dominio;


namespace GetEmpresa.Dao.Interface{
  public interface IClienteDao
        :IGenericDao<Cliente>
  {
      Cliente BuscarClientePorEmail(string _email);
      Cliente BuscarClientePorNome(string _nome);
      Cliente BuscarClientePorUrlPersonalizada(string UrlPersonal);
      Cliente BuscarClientePorCpf(string _cpf);
      Cliente BuscarClientePorCnpj(string _cnpj);
  }
}
