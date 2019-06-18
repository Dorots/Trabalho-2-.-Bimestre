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
                int op = 0, op1 = 0;
                List<Cafe> LC = new List<Cafe>();
                Simples cafe_simples = null;
                Especia cafe_especia = null;
                string nom="";
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
                            cafe_simples = new Simples();
                            Console.Write("Informe o nome do Café: ");
                            nom = Console.ReadLine();
                            Minha_Excessão.Validarnomec(nom);
                            cafe_simples.Nomec = nom;
                            Console.Write("Informe o defeito do café: ");
                            long def = long.Parse(Console.ReadLine());
                            Minha_Excessão.Validardefeitos(def);
                            cafe_simples.Defeitos = def;
                            Console.Write("Porcentagem de impurezas: ");
                            cafe_simples.QntImp = double.Parse(Console.ReadLine());
                            LC.Add(cafe_simples);
                            break;
                        case 2:
                            cafe_especia = new Especia();
                            Console.Write("Informe o nome do Café: ");
                            nom = Console.ReadLine();
                            Minha_Excessão.Validarnomec(nom);
                            cafe_especia.Nomec = nom;
                            Console.Write("Informe quantidade de defeitos do café: ");
                            long de = long.Parse(Console.ReadLine());
                            Minha_Excessão.Validardefeitos(de);
                            cafe_especia.Defeitos = de;
                            Console.Write("Informe a Classificação: ");
                            cafe_especia.Classificacao = Console.ReadLine();
                            LC.Add(cafe_especia);
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
                                        foreach (Cafe item in LC)
                                        {
                                            if (item.Categoria == "Simples")
                                            {
                                                Console.WriteLine(item.Mostra());
                                            }
                                        }
                                        Console.ReadKey();
                                        break;
                                    case 2:
                                        foreach (Cafe item in LC)
                                        {
                                            if (item.Categoria == "Especial")
                                            {
                                                Console.WriteLine(item.Mostra());
                                            }
                                        }
                                        Console.ReadKey();
                                        break;
                                }
                            } while (op1 != 3);

                            break;
                        case 4:
                            foreach (Cafe item in LC)
                            {
                                Console.WriteLine(item.Mostra());
                            }
                            Console.ReadKey();
                            break;
                    }
                } while (op != 5);
            }
            catch (ApplicationException x)
            {
                Console.WriteLine(x.Message);
            }
        }
    }
}
