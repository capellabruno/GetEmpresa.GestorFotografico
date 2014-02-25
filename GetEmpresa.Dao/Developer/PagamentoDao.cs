using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GetEmpresa.GestorFotografico.Domain.Financeiro;
using GenericFrameworkNhibernate;

namespace GetEmpresa.Dao.Developer
{
    public class PagamentoDao : GenericDao<Pagamento>, Interface.IPagamentoDao
    {
    }
}
