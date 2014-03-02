using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetEmpresa.GestorFotografico.Domain.Financeiro
{
    public class Divida
    {
        private long _id;

        public virtual long Id
        {
            get { return _id; }
            set { _id = value; }
        }
        private int _qtdeParcelas;

        public virtual int QtdeParcelas
        {
            get { return _qtdeParcelas; }
            set { _qtdeParcelas = value; }
        }
        private Gerencial.TipoPlanoFinanceiro _tipoPlano;

        public virtual Gerencial.TipoPlanoFinanceiro TipoPlano
        {
            get { return _tipoPlano; }
            set { _tipoPlano = value; }
        }
        private int _ano;

        public virtual int Ano
        {
            get { return _ano; }
            set { _ano = value; }
        }
        private int _mes;

        public virtual int Mes
        {
            get { return _mes; }
            set { _mes = value; }
        }
        private int _diaVencimento;

        public virtual int DiaVencimento
        {
            get { return _diaVencimento; }
            set { _diaVencimento = value; }
        }
        private DateTime _dataInicialCobranca;

        public virtual DateTime DataInicialCobranca
        {
            get { return _dataInicialCobranca; }
            set { _dataInicialCobranca = value; }
        }

        private decimal _valorCobranca;

        public virtual decimal ValorCobranca
        {
            get { return _valorCobranca; }
            set { _valorCobranca = value; }
        }
        private decimal _jurosMes;

        public virtual decimal JurosMes
        {
            get { return _jurosMes; }
            set { _jurosMes = value; }
        }

        private Cliente.Cliente _clienteCobranca;

        public virtual Cliente.Cliente ClienteCobranca
        {
            get { return _clienteCobranca; }
            set { _clienteCobranca = value; }
        }
    }
}
