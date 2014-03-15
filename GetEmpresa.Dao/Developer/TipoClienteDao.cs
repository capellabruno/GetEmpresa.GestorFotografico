using System;
using GetEmpresa.Dao.Interface;
<<<<<<< HEAD
using GenericFrameworkNhibernate;
using MundoDaFoto.Dominio;

namespace GetEmpresa.Dao.Developer{
  public class TipoClienteDao
        : GenericDao<TipoCliente> , ITipoClienteDao
  {
=======
using GetEmpresa.GestorFotografico.Domain;
using GenericFrameworkNhibernate;

namespace GetEmpresa.Dao.Developer{
  public class TipoClienteDao :GenericDao<TipoCliente> , ITipoClienteDao {
>>>>>>> 6d700399914a5d645230e276fe123f1993b5c6bd
  
  }//class
}
