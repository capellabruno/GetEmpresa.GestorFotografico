﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericFrameworkNhibernate;
using GetEmpresa.GestorFotografico.Domain.Contrato;

namespace GetEmpresa.Dao.Developer
{
    public class ContratoDao : GenericDao<ContratoFotografo>, Interface.IContratoDao
    {
    }
}
