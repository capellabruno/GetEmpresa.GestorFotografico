﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericFrameworkNhibernate;
using GetEmpresa.GestorFotografico.Domain.Cliente;

namespace GetEmpresa.Dao.Developer
{
    public class ClienteDao : GenericDao<Cliente>, Interface.IClienteDao
    {
    }
}
