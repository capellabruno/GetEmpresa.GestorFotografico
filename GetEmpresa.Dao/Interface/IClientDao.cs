using System;
using GenericFrameworkNhibernate;
using MundoDaFoto.Domain;


namespace GetEmpresa.Dao.Interface{
  public interface IClientDao
        :IGenericDao<Client>
  {
      Client BuscarClientPorEmail(string _email);
      Client BuscarClientPorNome(string _nome);
      Client BuscarClientPorUrlPersonalizada(string UrlPersonal);
      Client BuscarClientPorCpf(string _cpf);
      Client BuscarClientPorCnpj(string _cnpj);
  }
}
