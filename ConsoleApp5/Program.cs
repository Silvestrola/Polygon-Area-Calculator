using System;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int opcao;
                double n1, n2, n3;
                double area;               

                Console.WriteLine("Bem-vindo ao calculador de Área!");
                Console.WriteLine("Informe qual forma geométrica (polígonos) deseja calcular:\n");

                Console.Write("1 - Triângulo\n2 - Quadrado\n3 - Retângulo\n4 - Trapézio\n5 - Pentágono\n6 - Hexágono\n7 - Heptágono\n8 - Octógono\n9 - Eneágono\n10 - Decágono\n\nOpção: ");
                while (!int.TryParse(Console.ReadLine(), out opcao) || opcao > 10)
                {
                    Console.Write("Opção inválida, informe uma opção válida: ");
                }

                switch (opcao)
                {
                    case 1:
                        Console.Write("Informe o Comprimento da Base (cm): ");
                        n1 =double.Parse(Console.ReadLine());
                        Console.Write("Informe a Altura (cm): ");
                        n2 =double.Parse(Console.ReadLine());
                        area = (double)(n1 * n2) / 2.0;
                        Console.WriteLine(string.Concat("A área do Triângulo será: ", area, "cm³"));                       
                        break;
                    case 2:
                        Console.Write("Informe o Comprimento do lado (cm): ");
                        n1 =double.Parse(Console.ReadLine());
                        area = (double)Math.Pow(n1, 2);
                        Console.WriteLine(string.Concat("A área do Quadrado será: ", area, "cm³"));                       
                        break;
                    case 3:
                        Console.Write("Informe o Comprimento da Base (cm): ");
                        n1 =double.Parse(Console.ReadLine());
                        Console.Write("Informe a Altura (cm): ");
                        n2 =double.Parse(Console.ReadLine());
                        area = (double)n1 * n2;
                        Console.WriteLine(string.Concat("A área do Retângulo será: ", area, "cm³"));
                        break;
                    case 4:
                        Console.Write("Informe o Comprimento da Base Maior (cm): ");
                        n1 =double.Parse(Console.ReadLine());
                        Console.Write("Informe o Comprimento da Base Menor (cm): ");
                        n2 =double.Parse(Console.ReadLine());
                        Console.Write("Informe a Altura (cm): ");
                        n3 =double.Parse(Console.ReadLine());
                        area = (double)((n1 + n2) * n3) / 2.0;
                        Console.WriteLine(string.Concat("A área do Trapézio será: ", area, "cm³"));
                        break;
                    case 5:
                        Console.Write("Informe o Comprimento do lado (cm): ");
                        n1 =double.Parse(Console.ReadLine());
                        Console.Write("Informe o Apotema (cm): ");
                        n2 =double.Parse(Console.ReadLine());
                        area = (double) (5 * n1 * n2) / 2;
                        Console.WriteLine(string.Concat("A área do Pentágono será: ", area, "cm³"));
                        break;
                    case 6:
                        Console.Write("Informe o Comprimento do lado (cm): ");
                        n1 =double.Parse(Console.ReadLine());
                        Console.Write("Informe o Apotema (cm): ");
                        n2 =double.Parse(Console.ReadLine());
                        area = (double)(6 * n1 * n2) / 2;
                        Console.WriteLine(string.Concat("A área do Hexágono será: ", area, "cm³"));
                        break;
                    case 7:
                        Console.Write("Informe o Comprimento do lado (cm): ");
                        n1 =double.Parse(Console.ReadLine());
                        Console.Write("Informe o Apotema (cm): ");
                        n2 =double.Parse(Console.ReadLine());
                        area = (double)(7 * n1 * n2) / 2;
                        Console.WriteLine(string.Concat("A área do Heptágono será: ", area, "cm³"));
                        break;
                    case 8:
                        Console.Write("Informe o Comprimento do lado (cm): ");
                        n1 =double.Parse(Console.ReadLine());
                        Console.Write("Informe o Apotema (cm): ");
                        n2 =double.Parse(Console.ReadLine());
                        area = (double)(8 * n1 * n2) / 2;
                        Console.WriteLine(string.Concat("A área do Octógono será: ", area, "cm³"));
                        break;
                    case 9:
                        Console.Write("Informe o Comprimento do lado (cm): ");
                        n1 =double.Parse(Console.ReadLine());
                        Console.Write("Informe o Apotema (cm): ");
                        n2 =double.Parse(Console.ReadLine());
                        area = (double)(9 * n1 * n2) / 2;
                        Console.WriteLine(string.Concat("A área do Octógono será: ", area, "cm³"));
                        break;
                    case 10:
                        Console.Write("Informe o Comprimento do lado (cm): ");
                        n1 =double.Parse(Console.ReadLine());
                        Console.Write("Informe o Apotema (cm): ");
                        n2 =double.Parse(Console.ReadLine());
                        area = (double)(10 * n1 * n2) / 2;
                        Console.WriteLine(string.Concat("A área do Octógono será: ", area, "cm³"));
                        break;
                }

                Console.WriteLine();
                Console.WriteLine("Para realizar uma nova operação, digite ENTER");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
    }
    
    
