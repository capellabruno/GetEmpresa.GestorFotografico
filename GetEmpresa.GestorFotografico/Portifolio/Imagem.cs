using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetEmpresa.GestorFotografico.Domain.Portifolio
{
    public class Imagem
    {
        private long _id;

        public virtual long Id
        {
            get { return _id; }
            set { _id = value; }
        }
        private long _tamanho;

        public virtual long Tamanho
        {
            get { return _tamanho; }
            set { _tamanho = value; }
        }
        private string _ext;

        public virtual string Ext
        {
            get { return _ext; }
            set { _ext = value; }
        }
        private string _nome;

        public virtual string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }
        private string _caminho;

        public virtual string Caminho
        {
            get { return _caminho; }
            set { _caminho = value; }
        }
        private bool _principal;

        public virtual bool Principal
        {
            get { return _principal; }
            set { _principal = value; }
        }
        private IList<Comentario> _comentarios;

        public virtual IList<Comentario> Comentarios
        {
            get { return _comentarios; }
            set { _comentarios = value; }
        }
    }
}
