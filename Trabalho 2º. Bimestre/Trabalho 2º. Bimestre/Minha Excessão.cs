using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_2º.Bimestre
{
    class Minha_Excessão
    {
        public static void Validarnomec(string nomec)
        {
            if (nomec.Trim().Length == 0)
            {
                string msg = "O nome não pode estar em branco";
                ApplicationException e = new ApplicationException(msg);
                throw e;
            }
        }
        public static void Validardefeitos(long defeitos)
        {
            if (defeitos > 500)
            {
                string msg = "Café considerado como escolha/consumo";
                ApplicationException e = new ApplicationException(msg);
                throw e;
            }
        }
    }
}
