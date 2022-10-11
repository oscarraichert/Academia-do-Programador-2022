using System;

namespace EsquerdaVolver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Número de comandos emitidos: ");
                int numComandos = Convert.ToInt32(Console.ReadLine());

                if (numComandos == 0)
                {
                    break;
                }

                Console.Write("Comandos: ");
                string comandos = Console.ReadLine().ToUpper();

                string sentido = "N";

                int i = 0;

                foreach (char c in comandos)
                {
                    i++;

                    if (c == 'D')
                    {
                        if (sentido == "N")
                        {
                            sentido = "L";
                        }
                        else if (sentido == "L")
                        {
                            sentido = "S";
                        }
                        else if (sentido == "S")
                        {
                            sentido = "O";
                        }
                        else if (sentido == "O")
                        {
                            sentido = "N";
                        }
                    }

                    if (c == 'E')
                    {
                        if (sentido == "N")
                        {
                            sentido = "O";
                        }
                        else if (sentido == "O")
                        {
                            sentido = "S";
                        }
                        else if (sentido == "S")
                        {
                            sentido = "L";
                        }
                        else if (sentido == "L")
                        {
                            sentido = "N";
                        }
                    }
                    
                    /*if (c != 'E' || c != 'D')
                    {
                        sentido = "Comandos inválidos.";
                    }*/
                }

                if (i > numComandos || i < numComandos)
                {
                    Console.WriteLine("Você errou o número de comandos especificado. Tente novamente!\n");
                    continue;
                }

                Console.WriteLine($"{sentido}\n");
            }

        }
    }
}
