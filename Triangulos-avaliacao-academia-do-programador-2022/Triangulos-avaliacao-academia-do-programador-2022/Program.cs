using System;

public class Program
{
	public static void Main()
	{
		while (true)
		{
			Console.Write("Digite o valor de X: ");
			double ladoX = Convert.ToDouble(Console.ReadLine());
			Console.Write("Digite o valor de Y: ");
			double ladoY = Convert.ToDouble(Console.ReadLine());
			Console.Write("Digite o valor de Z: ");
			double ladoZ = Convert.ToDouble(Console.ReadLine());
			if (ladoX > ladoY + ladoZ || ladoY > ladoX + ladoZ || ladoZ > ladoX + ladoY)
			{
				Console.WriteLine("Triângulo inválido!");
				continue;
			}

			if (ladoX == ladoY && ladoX == ladoZ)
			{
				Console.WriteLine("Triângulo equilátero.");
			}
			else if (ladoX != ladoY && ladoX != ladoZ && ladoZ != ladoY)
			{
				Console.WriteLine("Triângulo escaleno.");
			}
			else
				Console.WriteLine("Triângulo isósceles.");
			Console.Write("Digite 1 para continuar ou 2 para sair: ");
			string menu = Console.ReadLine();
			if (menu == "1")
			{
				continue;
			}
			else if (menu == "2")
			{
				break;
			}
			else
			{
				Console.WriteLine("Opção inválida.");
				continue;
			}
		}
	}
}