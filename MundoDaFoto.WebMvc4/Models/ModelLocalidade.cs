using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Globalization;
using System.Web.Security;
using MundoDaFoto.Dominio;

namespace MundoDaFoto.WebMvc4.Models
{
    public class ModelLocalidade
    {
        private int _CitySelecionada;

        [Required()]
        [DataType(DataType.Text)]
        [Display(Name = "City")]
        public int CitySelecionada
        {
            get { return _CitySelecionada; }
            set { _CitySelecionada = value; }
        }

        private int _StateSelecionado;

        [Required()]
        [DataType(DataType.Text)]
        [Display(Name = "State")]
        public int StateSelecionado
        {
            get { return _StateSelecionado; }
            set { _StateSelecionado = value; }
        }

        private int _CountrySelecionado;

        [Required()]
        [DataType(DataType.Text)]
        [Display(Name="Country")]
        public int CountrySelecionado
        {
            get { return _CountrySelecionado; }
            set { _CountrySelecionado = value; }
        }


    }
}