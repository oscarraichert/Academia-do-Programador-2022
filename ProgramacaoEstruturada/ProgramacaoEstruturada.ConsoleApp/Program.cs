using System;

namespace ProgramacaoEstruturada.ConsoleApp
{
    internal class Program
    {
        static int[] valores;
        static int maiorValor = 0;
        static int menorValor = 0;

        static void Main(string[] args)
        {
            Menu();
        }

        static int[] ArrayDeValores()
        {
            Console.WriteLine("Digite os valores. ");

            int[] valores = new int[10];

            for (int i = 0; i < valores.Length; i++)
            {
                Console.Write($"Digite o valor {i + 1}: ");
                valores[i] = Convert.ToInt32(Console.ReadLine());
            }
            return valores;
        }

        static void MaiorValorSequencia(int[] valores, ref int maiorValor)
        {
            maiorValor = int.MinValue;

            for (int i = 0; i < valores.Length; i++)
            {
                if (valores[i] > maiorValor)
                {
                    maiorValor = valores[i];
                }
            }

            Console.WriteLine($"O maior valor é: " + maiorValor);
        }

        static void MenorValorSequencia(int[] valores, out int menorValor)
        {
            menorValor = int.MaxValue;

            for (int i = 0; i < valores.Length; i++)
            {
                if (valores[i] < menorValor)
                {
                    menorValor = valores[i];
                }
            }

            Console.WriteLine($"O menor valor é: {menorValor}");
        }

        static void ValorMedioSequencia(int[] valores)
        {
            double valorMedio = 0;

            for (int i = 0; i < valores.Length; i++)
            {
                valorMedio += valores[i];
            }

            valorMedio /= valores.Length;

            Console.WriteLine($"A média de valores é: {valorMedio}");
        }

        static void TresMaioresValores(int[] valores)
        {
            int i = 9;
            int j = 0;

            Array.Sort(valores);
            int[] tresMaiores = new int[3];

            Console.Write("Os maiores valores são: ");

            for (; i > 6; i--)
            {
                tresMaiores[j] = valores[i];
                Console.Write(tresMaiores[j] + " ");
                j++;
            }

            Console.WriteLine();
        }

        static void ValoresNegativosSequencia(int[] valores)
        {
            Console.Write("Os valores negativos são: ");

            int[] valoresNegativos = new int[10];
            for (int i = 0; i < valores.Length; i++)
            {
                if (valores[i] < 0)
                {
                    valoresNegativos[i] = valores[i];
                    Console.Write(valoresNegativos[i] + " ");
                }
            }
        }

        static void RemoverItemSequencia(int[] valores)
        {
            Console.Write("Remova um item da sequência digitando o valor do seu índice: ");
            int i = Convert.ToInt32(Console.ReadLine());

            valores[i - 1] = int.MinValue;
        }

        static void MostrarSequencia(int[] valores)
        {
            Console.WriteLine("\nOs valores da sequência são: ");

            for (int i = 0; i < valores.Length; i++)
            {
                if (valores[i] != int.MinValue)
                {
                    Console.WriteLine("Valor " + (i + 1) + ": " + valores[i] + " ");
                }
            }

            Console.WriteLine();
        }

        static void Menu()
        {
            string opcao = null;

            valores = ArrayDeValores();
            Console.Clear();

            Console.WriteLine($"\nOpção 1: Mostrar o maior valor da sequência.");
            Console.WriteLine($"Opção 2: Mostrar o menor valor da sequência.");
            Console.WriteLine($"Opção 3: Mostrar o valor médio da sequência.");
            Console.WriteLine($"Opção 4: Mostrar os três maiores valores da sequência.");
            Console.WriteLine($"Opção 5: Mostrar os valores negativos da sequência.");
            Console.WriteLine($"Opção 6: Mostrar a sequência completa.");
            Console.WriteLine($"Opção 7: Remover um item da sequência." +
                $"\nOpção 8: Sair.");

            while (opcao != "8")
            {
                opcao = Console.ReadLine();

                Console.WriteLine();

                switch (opcao)
                {
                    case "1":
                        MaiorValorSequencia(valores, ref maiorValor);
                        break;

                    case "2":
                        MenorValorSequencia(valores, out menorValor);
                        break;

                    case "3":
                        ValorMedioSequencia(valores);
                        break;

                    case "4":
                        TresMaioresValores(valores);
                        break;

                    case "5":
                        ValoresNegativosSequencia(valores);
                        break;

                    case "6":
                        MostrarSequencia(valores);
                        break;

                    case "7":
                        RemoverItemSequencia(valores);
                        break;

                    case "8":
                        break;

                    default:
                        Console.WriteLine("Comando inválido!\n");
                        break;
                }
            }
        }
    }
}