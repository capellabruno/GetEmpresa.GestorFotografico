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
    public class PessoaBaseModel
    {
        private long _id;
        [DataType(System.ComponentModel.DataAnnotations.DataType.Text)]
        [Display(Name="Cod")]
        [HiddenInput()]
        public virtual long Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _nome;

        [DataType(DataType.Text, ErrorMessage="Campo Nome deve ser informado.")]
        [Display(Name = "Nome")]
        [Required()]
        public virtual string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        private string _email;

        [DataType(DataType.EmailAddress, ErrorMessage = "Campo Email deve ser informado.")]
        [Display(Name = "E-mail")]
        [Required()]
        public virtual string Email
        {
            get { return _email; }
            set { _email = value; }
        }


        private string _endereco;

        [DataType(DataType.Text, ErrorMessage = "Campo Endereço deve ser informado.")]
        [Display(Name = "Endereço")]
        [Required()]
        public virtual string Endereco
        {
            get { return _endereco; }
            set { _endereco = value; }
        }

        private string _cidade;
        
        [DataType(DataType.Text, ErrorMessage = "Cidade deve ser informada.")]
        [Display(Name = "Cidade")]
        [Required()]
        public virtual string Cidade
        {
            get { return _cidade; }
            set { _cidade = value; }
        }

        private string _uf;
        [DataType(DataType.Text, ErrorMessage = "UF deve ser informado.")]
        [Display(Name = "UF")]
        [Required()]
        public virtual string Uf
        {
            get { return _uf; }
            set { _uf = value; }
        }

        private string _pais;

        [DataType(DataType.Text, ErrorMessage = "País deve ser informado.")]
        [Display(Name = "Pais")]
        [Required()]
        public virtual string Pais
        {
            get { return _pais; }
            set { _pais = value; }
        }

        private string _bairro;
        [DataType(DataType.Text, ErrorMessage = "Bairro deve ser informado.")]
        [Display(Name = "Bairro")]
        [Required()]
        public virtual string Bairro
        {
            get { return _bairro; }
            set { _bairro = value; }
        }

        private string _complemento;
        [DataType(DataType.Text)]
        [Display(Name = "Complemento")]
        [Required(ErrorMessage="Complemento do endereço deve ser informado")]
        public virtual string Complemento
        {
            get { return _complemento; }
            set { _complemento = value; }
        }

        private string _cep;
        [DataType(DataType.PostalCode, ErrorMessage = "CEP deve ser informado.")]
        [Display(Name = "Cep")]
        [Required()]
        public virtual string Cep
        {
            get { return _cep; }
            set { _cep = value; }
        }

        private string _documento;

        [DataType(DataType.Text, ErrorMessage = "CPF/CNPJ deve ser informado.")]
        [Display(Name = "CPF/CNPJ")]
        [Required()]
        public virtual string Documento
        {
            get { return _documento; }
            set { _documento = value; }
        }

        private string _telefone;

        [DataType(DataType.PhoneNumber, ErrorMessage = "Telefone deve ser informado.")]
        [Display(Name = "Telefone")]
        [Required()]
        public virtual string Telefone
        {
            get { return _telefone; }
            set { _telefone = value; }
        }

        private bool _ativo;
        [DataType(DataType.Text)]
        [Display(Name = "Ativo?")]
        public virtual bool Ativo
        {
            get { return _ativo; }
            set { _ativo = value; }
        }

    }
}