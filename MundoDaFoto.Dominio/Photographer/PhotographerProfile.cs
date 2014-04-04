using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MundoDaFoto.Dominio.Photographer {
    public class PhotographerProfile {
        private long _id;
        public virtual long Id {
            get { return _id; }
        }

        private DateTime _profileCreationDate;
        public virtual DateTime ProfileCreationDate {
            get { return _profileCreationDate; }
        }

        private DateTime _lastModificationDate;
        public virtual DateTime LastModificationDate {
            get { return _lastModificationDate; }
        }

        private string _gender;
        public virtual string Gender {
            get { return _gender; }
        }

        private string _whoAmI;
        public virtual string WhoAmI {
            get { return _whoAmI; }
        }

        private string _email;
        public virtual string Email {
            get { return _email; }
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

        private Cidade _city;
        public virtual Cidade City {
            get { return _city; }
        }

        private String _address;
        public virtual String Address {
            get { return _address; }
        }

        private bool _publicProfile;
        public virtual bool PublicProfile {
            get { return _publicProfile; }
        }

        private bool _iWantToBeContacted;
        public virtual bool IWantToBeContacted {
            get { return _iWantToBeContacted; }
        }

        public virtual bool IsNull() {
            return false;
        }
    }// class
}
