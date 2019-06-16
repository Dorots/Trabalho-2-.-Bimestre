using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_2º.Bimestre
{
    class Especial : Cafe
    {
        private List<Cafe> LS;

        public Especial()
        {
            LS = new List<Cafe>(); 
        }

        override public void Gravar(Cafe coffee)
        {
            LS.Add(coffee);
        }
        public override List<Cafe> Mostra()
        {
            return LS;
        }
    }
}
