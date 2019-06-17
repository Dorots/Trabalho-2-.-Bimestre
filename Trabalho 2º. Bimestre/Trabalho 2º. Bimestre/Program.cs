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
            try
            {
                int op,op1;
                Simples coffee=null;
                Especia coffe=null;
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
                            coffee = new Simples();
                            Console.Write("Informe o nome do Café: ");
                            coffee.Nomec = Console.ReadLine();
                            Console.Write("Informe o defeito do café: ");
                            coffee.Defeitos = Console.ReadLine();
                            coffee.Gravar(coffee);

                            break;
                        case 2:
                            coffe = new Especia();
                            Console.Write("Informe o nome do Café: ");
                            coffe.Nomec = Console.ReadLine();
                            Console.Write("Informe o defeito do café: ");
                            coffe.Defeitos = Console.ReadLine();
                            coffe.Gravar(coffe);
                            break;
                        case 3:
                            do
                            {
                                Console.Clear();
                                Console.WriteLine("1. Tipo Simples");
                                Console.WriteLine("2. Tipo Especial");
                                Console.WriteLine("3. Sair");
                                Console.Write("Sua opção: ");
                                op1 = int.Parse(Console.ReadLine());
                                switch (op1)
                                {
                                    case 1:
                                        List<Cafe> L = new List<Cafe>();
                                        L = coffee.Mostra();
                                        string s = "";
                                        foreach (Simples item in L)
                                        {
                                            s = item.Nomec + "/" + item.Defeitos + "... ";
                                        }
                                        Console.WriteLine(s);
                                        break;
                                }
                            } while (op1 != 3);

                            break;
                        case 4:

                            break;
                    }


                } while (op != 5);
                Console.ReadKey();
            }
            catch (ApplicationException x)
            {
                Console.WriteLine(x.Message);
            }
        }
    }
}
