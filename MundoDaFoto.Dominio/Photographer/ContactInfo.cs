using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MundoDaFoto.Dominio.Photographer {
    public class ContactInfo {
        protected ContactInfo() { }
        public ContactInfo(string alternateEmail, string webSite, string contactPhone1, string contactPhone2, bool iWantToBeContacted, string address) {
            _alternateEmail = alternateEmail;
            _webSite = webSite;
            _contactPhone1 = contactPhone1;
            _contactPhone2 = contactPhone2;
            _iWantToBeContacted = iWantToBeContacted;
            _address = address;
        }
        private string _alternateEmail;
        public virtual string AlternateEmail {
            get { return _alternateEmail; }
        }

        private string _webSite;
        public virtual string WebSite {
            get { return _webSite; }
        }

        private string _contactPhone1;
        public virtual string ContactPhone1 {
            get { return _contactPhone1; }
        }

        private string _contactPhone2;
        public virtual string ContactPhone2 {
            get { return _contactPhone2; }
        }

        private string _address;
        public virtual string Address {
            get { return _address; }
        }

        private bool _iWantToBeContacted;
        public virtual bool IWantToBeContacted {
            get { return _iWantToBeContacted; }
        }
    } //class
}
