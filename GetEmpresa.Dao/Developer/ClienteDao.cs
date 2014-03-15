using System;
using MundoDaFoto.Dominio;
using GetEmpresa.Dao.Interface;
using GenericFrameworkNhibernate;
using NHibernate;
using NHibernate.Criterion;

namespace GetEmpresa.Dao.Developer{
  public class ClienteDao
        :GenericDao<Cliente> , IClienteDao
  {

      public Cliente BuscarClientePorEmail(string _email)
      {          
          ICriteria _criteria;
          _criteria = base.CurrentSession.CreateCriteria(typeof(Cliente));
          _criteria.Add(Restrictions.Eq("Email", _email));

          return _criteria.UniqueResult<Cliente>();   
      }

      public Cliente BuscarClientePorNome(string _nome)
      {
          ICriteria _criteria;
          _criteria = base.CurrentSession.CreateCriteria(typeof(Cliente));
          _criteria.Add(Restrictions.Eq("Nome", _nome));

          return _criteria.UniqueResult<Cliente>();   
      }

      public Cliente BuscarClientePorUrlPersonalizada(string UrlPersonal)
      {
          throw new NotImplementedException();
      }

      public Cliente BuscarClientePorCpf(string _cpf)
      {
          throw new NotImplementedException();
      }

      public Cliente BuscarClientePorCnpj(string _cnpj)
      {
          throw new NotImplementedException();
      }

  }
}
