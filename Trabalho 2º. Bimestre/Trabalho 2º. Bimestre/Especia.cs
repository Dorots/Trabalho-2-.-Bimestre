using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_2º.Bimestre
{
    class Especia : Cafe
    {
        private string classificacao;

        public string Classificacao
        {
            set { classificacao = value; }
        }
        public Especia() { categoria = "Especial"; }
        public override string Mostra() { return "Nome do café: "+Nomec + " Defeitos:"  + Defeitos+" Classificação: "+classificacao; }
    }
}
