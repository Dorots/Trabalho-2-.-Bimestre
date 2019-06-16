using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_2º.Bimestre
{
   abstract class Café
    {

        private char tipo;
        private string nome;
        private int defeitos;
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

    }
}
