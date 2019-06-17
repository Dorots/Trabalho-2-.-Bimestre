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
                        Comum coffee = null;
                        Console.Write("Informe o nome do Café: ");
                        coffee.Nomec = Console.ReadLine();
                        Console.Write("Informe o defeito do café: ");
                        coffee.Defeitos = Console.ReadLine();
                        coffee.Gravar(coffee);

                        break;
                    case 2:
                        Especial coffe = null;
                        Console.Write("Informe o nome do Café: ");
                        coffe.Nomec = Console.ReadLine();
                        Console.Write("Informe o defeito do café: ");
                        coffe.Defeitos = Console.ReadLine();
                        coffe.Gravar(coffe);

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
