using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericFrameworkNhibernate;
using MundoDaFoto.Domain.Photographer;

namespace GetEmpresa.Dao.Interface {
    public interface IPhotographerProfileDao : IGenericDao<PhotographerProfile>{
        long RowCount(string _email);
        PhotographerProfile Get(string _email);
    }
}
