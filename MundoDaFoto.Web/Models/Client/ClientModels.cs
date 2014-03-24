using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace MundoDaFoto.Web.Models
{
    public class ClientModels
    {
        [DataType(DataType.Text)]
        public long Id { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public long MunicipioSelecionado { get; set; }

        public long TipoClienteSelecionado { get; set; }

        public bool Ativo { get; set; }


        /*Listas */
        [Required(ErrorMessage="Pais não foi informado")]
        public IEnumerable<SelectListItem> Paises { get; set; }

        [Required(ErrorMessage = "Estado não foi informado")]
        public IEnumerable<SelectListItem> Estados { get; set; }

        [Required(ErrorMessage = "Municipio não foi informado")]
        public IEnumerable<SelectListItem> Cidades { get; set; }

        [Required(ErrorMessage = "Tipo de Acesso não foi informado")]
        public IEnumerable<SelectListItem> TipoClientes { get; set; }


    }
}