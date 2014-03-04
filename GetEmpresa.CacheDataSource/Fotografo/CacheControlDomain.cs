using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetEmpresa.CacheDataSource.Fotografo
{
    public class CacheControlDomain
    {
        private string _column;

        public string Column
        {
            get { return _column; }
            set { _column = value; }
        }
        private string _value;

        public string Value
        {
            get { return _value; }
            set { _value = value; }
        }

    }
}
