using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_2º.Bimestre
{
    class Minhaex
    {
        public static void ValidarNome(string nome)
        {
            if (nome.Trim().Length == 0)
            {
                string msg = "O nome não pode estar em branco";
                ApplicationException e = new ApplicationException(msg);
                throw e;
            }
        }
        public static void ValidarNota(double nota)
        {
            if (nota < 0 || nota > 10)
            {
                string msg = "A nota deve estar entre 0 e 10";
                ApplicationException e = new ApplicationException(msg);
                throw e;
            }
        }
        public static void Media(double nota)
        {
            if (nota < 6)
            {
                string msg = "Fora da Média";
                ApplicationException e = new ApplicationException(msg);
                throw e;
            }
        }
    }
}
