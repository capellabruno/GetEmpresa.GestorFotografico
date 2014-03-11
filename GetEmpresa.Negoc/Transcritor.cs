using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GetEmpresa.GestorFotografico.Domain.Cliente;
using GetEmpresa.GestorFotografico.Domain.Gerencial;

namespace GetEmpresa.Negoc
{
    public class Transcritor
    {
        public static void Transcreve(DataRow[] _origem, ref  List<ClientePortal> _destino)
        {
            if (_destino == null)
            {
                _destino = new List<ClientePortal>();
            }

            if (_origem != null && _origem.Length > 0)
            {
                foreach (DataRow item in _origem)
                {
                    ClientePortal _cliente = new ClientePortal();
                    Transcreve(item, ref _cliente);
                    _destino.Add(_cliente);
                }
            }
        }

        public static void Transcreve(DataRow _origem, ref  ClientePortal _destino)
        {
            if (_destino == null)
                _destino = new ClientePortal();

            _destino.Id = Convert.ToInt64(_origem[0]);
            _destino.Nome = _origem["Nome"].ToString();
            _destino.Pais = _origem["Pais"].ToString();
            _destino.Telefone = _origem["Telefone"].ToString();
            _destino.Uf = _origem["Uf"].ToString();

            if (_origem["UrlPessoal"] != DBNull.Value)
                _destino.UrlPessoal = _origem["UrlPessoal"].ToString();

            _destino.Ativo = Convert.ToBoolean(_origem["Ativo"]);
            _destino.Bairro = _origem["Bairro"].ToString();
            _destino.Cep = _origem["Cep"].ToString();
            _destino.Cidade = _origem["Cidade"].ToString();
            _destino.Complemento = _origem["Complemento"].ToString();
            _destino.Documento = _origem["Documento"].ToString();
            _destino.Email = _origem["Email"].ToString();
            _destino.Endereco = _origem["Endereco"].ToString();

            if (_origem["DataProximaTroca"] != DBNull.Value)
                _destino.DataProximatroca = Convert.ToDateTime(_origem["DataProximaTroca"]);

        }

        public static void Transcreve(DataRow[] _origem, ref  List<Cliente> _destino)
        {
            if (_destino == null)
            {
                _destino = new List<Cliente>();
            }

            if (_origem != null && _origem.Length > 0)
            {
                foreach (DataRow item in _origem)
                {
                    Cliente _cliente = new Cliente();
                    Transcreve(item, ref _cliente);
                    _destino.Add(_cliente);
                }
            }
        }

        public static void Transcreve(DataRow _origem, ref  Cliente _destino)
        {
            if (_destino == null)
                _destino = new Cliente();

            _destino.Id = Convert.ToInt64(_origem[0]);
            _destino.Nome = _origem["Nome"].ToString();
            _destino.Pais = _origem["Pais"].ToString();
            _destino.Telefone = _origem["Telefone"].ToString();
            _destino.Uf = _origem["Uf"].ToString();
            _destino.Ativo = Convert.ToBoolean(_origem["Ativo"]);
            _destino.Bairro = _origem["Bairro"].ToString();
            _destino.Cep = _origem["Cep"].ToString();
            _destino.Cidade = _origem["Cidade"].ToString();
            _destino.Complemento = _origem["Complemento"].ToString();
            _destino.Documento = _origem["Documento"].ToString();
            _destino.Email = _origem["Email"].ToString();
            _destino.Endereco = _origem["Endereco"].ToString();

        }

        public static void Transcreve(DataRow[] _origem, ref  List<ConfigurationSystem> _destino)
        {
            if (_destino == null)
            {
                _destino = new List<ConfigurationSystem>();
            }

            if (_origem != null && _origem.Length > 0)
            {
                foreach (DataRow item in _origem)
                {
                    ConfigurationSystem _config = new ConfigurationSystem();
                    Transcreve(item, ref _config);
                    _destino.Add(_config);
                }

            }
        }

        public static void Transcreve(DataRow _origem, ref  ConfigurationSystem _destino)
        {
            if (_destino == null)
                _destino = new ConfigurationSystem();

            _destino.Id = Convert.ToInt32(_origem["idPortalConfiguration"]);

            if (_origem["Facebook"] != DBNull.Value)
            {
                _destino.Facebook = _origem["Facebook"].ToString();
            }

            if (_origem["Twiter"] != DBNull.Value)
            {
                _destino.Twiter = _origem["Twiter"].ToString();
            }

            if (_origem["GooglePlus"] != DBNull.Value)
            {
                _destino.GooglePlus = _origem["GooglePlus"].ToString();
            }

            if (_origem["FormaPagamento"] != DBNull.Value)
            {
                _destino.FormaPagamento = ((EnumFormaPagamento)Convert.ToInt32(_origem["FormaPagamento"]));
            }

            if (_origem["Banco"] != DBNull.Value)
            {
                _destino.CodigoBanco = Convert.ToInt32(_origem["Banco"]);
            }

            if (_origem["BancoNome"] != DBNull.Value)
            {
                _destino.NomeBanco = _origem["BancoNome"].ToString();
            }

            if (_origem["Agencia"] != DBNull.Value)
            {
                _destino.Agencia = Convert.ToInt32(_origem["Agencia"]);
            }

            if (_origem["AgenciaCodigo"] != DBNull.Value)
            {
                _destino.DigitoAgencia = Convert.ToInt32(_origem["AgenciaCodigo"]);
            }

            if (_origem["Conta"] != DBNull.Value)
            {
                _destino.ContaBanco = Convert.ToInt32(_origem["Conta"]);
            }

            if (_origem["ContaCodigo"] != DBNull.Value)
            {
                _destino.DigitoConta = Convert.ToInt32(_origem["ContaCodigo"]);
            }

            if (_origem["PagSeguroEmail"] != DBNull.Value)
            {
                _destino.EmailPagSeguro = _origem["PagSeguroEmail"].ToString();
            }

            if (_origem["PagSeguroToken"] != DBNull.Value)
            {
                _destino.TokenPagSeguro = _origem["PagSeguroToken"].ToString();
            }

            if (_origem["PayPalEmail"] != DBNull.Value)
            {
                _destino.EmailPayPal = _origem["PayPalEmail"].ToString();
            }

            if (_origem["PayPalToken"] != DBNull.Value)
            {
                _destino.TokenPayPal = _origem["PayPalToken"].ToString();
            }

            if (_origem["PessoaPortal_idPessoaPortal"] != DBNull.Value)
            {
                _destino.Cliente = new ClientePortal() { Id = Convert.ToInt64(_origem["PessoaPortal_idPessoaPortal"]) };
            }

        }

    }
}
