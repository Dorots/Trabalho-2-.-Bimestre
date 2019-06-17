using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_2º.Bimestre
{
    class Simples : Cafe
    {
        protected List<Cafe> LC;


        public Simples()
        { LC = new List<Cafe>(); }

        override public void Gravar(Cafe coffee)
        {
            LC.Add(coffee);
        }

        public override List<Cafe> Mostra()
        {
            return LC;
        }
    }
}
