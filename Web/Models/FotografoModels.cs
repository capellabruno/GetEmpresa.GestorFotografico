using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Globalization;
using System.Web.Mvc;
using System.Web.Security;
using GetEmpresa.GestorFotografico.Domain.Gerencial;

namespace Web.Models
{
    public class FotografoModels : PessoaBaseModel
    {
        [DataType(DataType.Password, ErrorMessage = "Senha deve ser informada.")]
        [Display(Name = "Senha")]
        [Required()]
        public string Senha { get; set; }
    }
}