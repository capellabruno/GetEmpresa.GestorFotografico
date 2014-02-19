﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetEmpresa.GestorFotografico.Domain.Usuario
{
    public class GrupoUsuario
    {
        private long _id;

        public virtual long Id
        {
            get { return _id; }
            set { _id = value; }
        }
        private string _nome;

        public virtual string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }
        private bool _ativo;

        public virtual bool Ativo
        {
            get { return _ativo; }
            set { _ativo = value; }
        }

    }
}