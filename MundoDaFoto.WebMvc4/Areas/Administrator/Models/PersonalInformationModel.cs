using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MundoDaFoto.Domain;

namespace MundoDaFoto.WebMvc4.Areas.Administrator.Models
{
    public class PersonalInformationModel
    {
        private string _zipCode;

        public string ZipCode
        {
            get { return _zipCode; }
            set { _zipCode = value; }
        }
        private int _number;

        public int Number
        {
            get { return _number; }
            set { _number = value; }
        }
        private string _complement;

        public string Complement
        {
            get { return _complement; }
            set { _complement = value; }
        }
        private int _selectedCountry;

        public int SelectedCountry
        {
            get { return _selectedCountry; }
            set { _selectedCountry = value; }
        }
        private int _selectedState;

        public int SelectedState
        {
            get { return _selectedState; }
            set { _selectedState = value; }
        }
        private int _selectedCity;

        public int SelectedCity
        {
            get { return _selectedCity; }
            set { _selectedCity = value; }
        }
        private string _bairro;

        public string Bairro
        {
            get { return _bairro; }
            set { _bairro = value; }
        }
        private string _document;

        public string Document
        {
            get { return _document; }
            set { _document = value; }
        }


    }
}