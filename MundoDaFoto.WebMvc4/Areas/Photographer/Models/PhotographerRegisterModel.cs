using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MundoDaFoto.Domain;

namespace MundoDaFoto.WebMvc4.Areas.Photographer.Models {
    public class PhotographerRegisterModel {
        public string Name { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? LastModificationDate { get; set; }
        public DateTime? BirthDate { get; set; }
        public string Gender { get; set; }
        public string WhoAmI { get; set; }
        public string Email { get; set; }
        public string AlternateEmail { get; set; }
        public string WebSite { get; set; }
        public string ContactPhone1 { get; set; }
        public string ContactPhone2 { get; set; }
        public City City { get; set; }
        public string Address { get; set; }
        public bool Public { get; set; }
        public bool IWantToBeContacted { get; set; }
    } //class
}