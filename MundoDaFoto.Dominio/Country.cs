﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MundoDaFoto.Domain{
    public class Country{
        public virtual long Id { get; set; }

        public virtual string Name { get; set; }

        public virtual string Acronym { get; set; }

        public virtual int Code { get; set; }

        public virtual string FullDescription() {
            return string.Format("{0} - {1} - {2}", Code, Acronym, Name);
        }

    } // class
}
