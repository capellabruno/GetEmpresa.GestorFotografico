using GenericFrameworkNhibernate;
using MundoDaFoto.Dominio.Photographer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetEmpresa.Dao.Interface {
    public interface IPhotographerProfileDao : IGenericDao<PhotographerProfile>{
        long RowCount(string email);
        PhotographerProfile Get(string _email);
    }// class
}
