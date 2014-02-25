using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericFrameworkNhibernate;
using GetEmpresa.GestorFotografico.Domain.Usuario;

namespace GetEmpresa.Dao.Developer
{
    public class UsuarioDao : GenericDao<UsuarioSistema>, Interface.IUsuarioDao
    {
    }
}
