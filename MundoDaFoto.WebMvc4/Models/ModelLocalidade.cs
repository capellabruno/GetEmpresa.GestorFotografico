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
        private int _cidadeSelecionada;

        [Required()]
        [DataType(DataType.Text)]
        [Display(Name = "City")]
        public int CidadeSelecionada
        {
            get { return _cidadeSelecionada; }
            set { _cidadeSelecionada = value; }
        }

        private int _estadoSelecionado;

        [Required()]
        [DataType(DataType.Text)]
        [Display(Name = "State")]
        public int EstadoSelecionado
        {
            get { return _estadoSelecionado; }
            set { _estadoSelecionado = value; }
        }

        private int _paisSelecionado;

        [Required()]
        [DataType(DataType.Text)]
        [Display(Name="Country")]
        public int PaisSelecionado
        {
            get { return _paisSelecionado; }
            set { _paisSelecionado = value; }
        }


    }
}