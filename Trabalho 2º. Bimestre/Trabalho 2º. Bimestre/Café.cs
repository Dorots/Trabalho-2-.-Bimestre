using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_2º.Bimestre
{
   abstract class Café
    {

        private string tipo;
        private string nome;
        private double defeitos;
        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public double Defeitos
        {
            get { return defeitos ; }
            set { defeitos = value; }
        }
        public Café(string t,string n, double d) { tipo = t;nome = n;defeitos = d; }

        public string Mostracafé()
        {
            return nome + "/" + tipo + "/" + "/" + defeitos; 
        }
    }
}
