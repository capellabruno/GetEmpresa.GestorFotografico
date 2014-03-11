using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web.Models;
using GetEmpresa.GestorFotografico.Domain.Gerencial;


namespace Web.Filters
{
    public class Transcritor
    {
        public static void TranscreveWeb(ConfigurationSystem _origem, ref PortalConfigurationModels _destino ) {
            if (_destino == null)
                _destino = new PortalConfigurationModels();

            _destino.Agencia = _origem.Agencia;
            _destino.Cliente = _origem.Cliente;
            _destino.CodigoBanco = _origem.CodigoBanco;
            _destino.ContaBanco = _origem.ContaBanco;
            _destino.DigitoAgencia = _origem.DigitoAgencia;
            _destino.DigitoConta = _origem.DigitoConta;
            _destino.EmailPagSeguro = _origem.EmailPagSeguro;
            _destino.EmailPayPal = _origem.EmailPayPal;
            _destino.Facebook = _origem.Facebook;
            _destino.FormaPagamento = _origem.FormaPagamento;
            _destino.GooglePlus = _origem.GooglePlus;
            _destino.NomeBanco = _origem.NomeBanco;
            _destino.TokenPagSeguro = _origem.TokenPagSeguro;
            _destino.TokenPayPal = _origem.TokenPayPal;
            _destino.Twiter = _origem.Twiter;
        }

        public static void TranscreveWeb(PortalConfigurationModels _origem, ref ConfigurationSystem _destino)
        {
            if (_destino == null)
                _destino = new ConfigurationSystem();

            _destino.Agencia = _origem.Agencia;
            _destino.Cliente = _origem.Cliente;
            _destino.CodigoBanco = _origem.CodigoBanco;
            _destino.ContaBanco = _origem.ContaBanco;
            _destino.DigitoAgencia = _origem.DigitoAgencia;
            _destino.DigitoConta = _origem.DigitoConta;
            _destino.EmailPagSeguro = _origem.EmailPagSeguro;
            _destino.EmailPayPal = _origem.EmailPayPal;
            _destino.Facebook = _origem.Facebook;
            _destino.FormaPagamento = _origem.FormaPagamento;
            _destino.GooglePlus = _origem.GooglePlus;
            _destino.NomeBanco = _origem.NomeBanco;
            _destino.TokenPagSeguro = _origem.TokenPagSeguro;
            _destino.TokenPayPal = _origem.TokenPayPal;
            _destino.Twiter = _origem.Twiter;
            
        }
    }
}