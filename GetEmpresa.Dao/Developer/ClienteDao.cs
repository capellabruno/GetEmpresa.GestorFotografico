using System;
using MundoDaFoto.Dominio;
using GetEmpresa.Dao.Interface;
using GenericFrameworkNhibernate;
using NHibernate;
using NHibernate.Criterion;

namespace GetEmpresa.Dao.Developer{
  public class ClientDao
        :GenericDao<Client> , IClientDao
  {

      public Client BuscarClientPorEmail(string _email)
      {          
          ICriteria _criteria;
          _criteria = base.CurrentSession.CreateCriteria(typeof(Client));
          _criteria.Add(Restrictions.Eq("Email", _email));

          return _criteria.UniqueResult<Client>();   
      }

      public Client BuscarClientPorNome(string _nome)
      {
          ICriteria _criteria;
          _criteria = base.CurrentSession.CreateCriteria(typeof(Client));
          _criteria.Add(Restrictions.Eq("Nome", _nome));

          return _criteria.UniqueResult<Client>();   
      }

      public Client BuscarClientPorUrlPersonalizada(string UrlPersonal)
      {
          throw new NotImplementedException();
      }

      public Client BuscarClientPorCpf(string _cpf)
      {
          throw new NotImplementedException();
      }

      public Client BuscarClientPorCnpj(string _cnpj)
      {
          throw new NotImplementedException();
      }

  }
}
