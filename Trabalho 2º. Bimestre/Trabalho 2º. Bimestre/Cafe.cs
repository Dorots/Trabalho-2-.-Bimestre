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
        private string defeitos;

        public Cafe()
        { }

        public string Nomec
        {
            get { return nomec; }
            set { nomec = value; }
        }

        public string Defeitos
        {
            get { return defeitos; }
            set { defeitos = value; }
        }
        abstract public void Gravar(Cafe coffee);

        abstract public List<Cafe> Mostra();
    }
}
