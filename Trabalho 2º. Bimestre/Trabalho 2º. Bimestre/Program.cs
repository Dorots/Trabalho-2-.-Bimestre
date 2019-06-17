using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_2º.Bimestre
{
    class Program
    {
        static void Main(string[] args)
        {
            int op;
            do
            {
                Console.Clear();
                Console.WriteLine("1.Cadastrar Café simples ");
                Console.WriteLine("2.Cadastrar Café especial");
                Console.WriteLine("3.Mostar cafés por tipo: ");
                Console.WriteLine("4.Mostrar todos os cafés : ");
                Console.WriteLine("5.Encerrar");
                Console.Write("Sua opção:");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                      
                        break;
                    case 2:
                        
                        break;
                    case 3:
                        
                        break;
                    case 4:

                        break;
                }


            } while (op != 5);
            Console.ReadKey();
        }
    }
}
