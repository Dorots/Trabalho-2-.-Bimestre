using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_2º.Bimestre
{
    abstract class Cafe
    {
        private string nomec;
        private long defeitos;
        protected string categoria;

        public string Nomec
        {
            get { return nomec; }
            set { nomec = value; }
        }

        public long Defeitos
        {
            get { return defeitos; }
            set { defeitos = value; }
        }

        public string Categoria { get => categoria; }

        abstract public string Mostra();
    }
}
