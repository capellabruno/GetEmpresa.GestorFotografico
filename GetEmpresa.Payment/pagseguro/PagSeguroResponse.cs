using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace GetEmpresa.Payment.pagseguro
{
    public class PagSeguroResponse
    {
        private string _code;

        [XmlElement("code")]
        public string Code
        {
            get { return _code; }
            set { _code = value; }
        }

        private DateTime _date;

        [XmlElement("date")]
        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }

        private Uri _uriRedirect;
        
        [XmlIgnore()]
        public Uri UriRedirect
        {
            get { return _uriRedirect; }
            set { _uriRedirect = value; }
        }


    }
}
