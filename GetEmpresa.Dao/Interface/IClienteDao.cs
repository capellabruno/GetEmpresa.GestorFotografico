using System;
using GenericFrameworkNhibernate;
<<<<<<< HEAD
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
=======
using GetEmpresa.GestorFotografico.Domain;


namespace GetEmpresa.Dao.Interface{
    public interface IClienteDao : IGenericDao<Cliente>{
  
    }
>>>>>>> 6d700399914a5d645230e276fe123f1993b5c6bd
}
