using System;

namespace DiamanteDeX.ConsoleApp
{
    internal class Program
    {
        public static void Main()
        {
            Console.Write("Digite um número ímpar para fazer o diamante: ");
            int maiorLinha = Convert.ToInt32(Console.ReadLine());

            if (maiorLinha % 2 == 0)
            {
                Console.WriteLine("Diamante inválido!");
                return;
            }

            int espacos = maiorLinha / 2;
            for (int tamanhoLinha = 1; tamanhoLinha < maiorLinha; tamanhoLinha += 2)
            {
                EscreverLinha(tamanhoLinha, espacos--);
            }

            for (int tamanhoLinha = maiorLinha; tamanhoLinha > 0; tamanhoLinha -= 2)
            {
                EscreverLinha(tamanhoLinha, espacos++);
            }
        }

        public static void EscreverLinha(int tamanhoLinha, int qntEspacos)
        {
            Console.WriteLine($"{new string(' ', qntEspacos)} {new string('x', tamanhoLinha)}");
        }
    }
}