using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_2º.Bimestre
{
    class Simples : Cafe
    {
        private double qntImp;
        public Simples() { categoria = "Simples"; }

        public double QntImp
        {
            set { qntImp = value; }
        }

        public override string Mostra() { return "Nome do Café: "+Nomec + " - Defeitos: " + Defeitos+" - Quantidade de impurezas: "+qntImp.ToString()+"%"; }
    }
}
