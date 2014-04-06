using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MundoDaFoto.Dominio.Photographer {
    public class PhotographerProfile {
        protected PhotographerProfile() {
        }

        public PhotographerProfile(string email) {
            _lastModificationDate = DateTime.Now;
            _creationDate = DateTime.Now;
            _email = email;
        }

        private long _id;
        public virtual long Id {
            get { return _id; }
        }

        private string _name;
        public virtual string Name {
            get { return _name; }
        }

        private string _email;
        public virtual string Email {
            get { return _email; } 
        }

        private DateTime? _birthDate;
        public virtual DateTime? BirthDate {
            get { return _birthDate; }
        }

        private string _gender;
        public virtual string Gender {
            get { return _gender; }
        }

        private string _whoAmI;
        public virtual string WhoAmI {
            get { return _whoAmI; }
        }

        private DateTime? _creationDate;
        public virtual DateTime? CreationDate {
            get { return _creationDate; }
        }

        private DateTime? _lastModificationDate;
        public virtual DateTime? LastModificationDate {
            get { return _lastModificationDate; }
        }

        private ContactInfo _contactInfo;
        public virtual ContactInfo ContactInfo {
            get { return _contactInfo; }
        }

        private bool _public;
        public virtual bool Public {
            get { return _public; }
        }

        public virtual bool IsValid() {
            if (string.IsNullOrEmpty(_email))
                return false;
            if (!_creationDate.HasValue)
                return false;
            if (!_lastModificationDate.HasValue)
                return false;

            return true;
        }

        public virtual bool IsNull() {
            return false;
        }

        public virtual void AddBasicInfo(string name, DateTime? birthDate, string gender) {
            _name = name;
            _birthDate = birthDate;
            _gender = gender;
        }

        public virtual void AddContactInfo(ContactInfo contactInfo){
            _contactInfo = contactInfo;
        }
    } //class
}
