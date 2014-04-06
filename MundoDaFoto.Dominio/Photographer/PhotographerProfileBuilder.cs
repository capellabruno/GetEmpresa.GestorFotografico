using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MundoDaFoto.Dominio.Photographer {
    public class PhotographerProfileBuilder {
        private ContactInfo _contactInfo;
        private PhotographerProfile profile;

        public PhotographerProfileBuilder(string email) {
            profile = new PhotographerProfile(email);
        }

        public PhotographerProfileBuilder AddBasicInfo(string name, DateTime? birthDate, string gender) { 
            profile.AddBasicInfo(name, birthDate, gender);
            return this;
        }

        public PhotographerProfileBuilder AddContactInfo(string alternateEmail, string webSite, string contactPhone1, string contactPhone2, bool iWantToBeContacted, string address) { 
            ContactInfo contactInfo = new ContactInfo(alternateEmail, webSite, contactPhone1, contactPhone2, iWantToBeContacted, address);
            profile.AddContactInfo(contactInfo);
            return this;
        }

        public PhotographerProfile Build() {
            return profile;
        }
    } //class
}
