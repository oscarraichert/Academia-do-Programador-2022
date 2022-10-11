using System;

namespace ClubeDaLeitura2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var tela = new Tela();
            
            AppDomain.CurrentDomain.ProcessExit += tela.Fechando;

            tela.MenuPrincipal();
        }
    }
}