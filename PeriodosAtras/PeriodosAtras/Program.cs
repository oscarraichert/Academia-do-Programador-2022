using System;

namespace PeriodosAtras
{
    internal class Program
    {
        public static int dias = 0;
        public static int meses = 0;
        public static int anos = 0;
        public static int semanas = 0;
        public static int horas = 0;
        public static int minutos = 0;
        public static int segundos = 0;
        public static DateTime DataPassada;
        public static string Mensagem = "";

        static void Main(string[] args)
        {
            PegarData();
            CalcularTempo();
            Console.WriteLine(MostrarMensagem()); 
        }

        public static void PegarData()
        {
            Console.Write("Informe uma data passada: ");
            DataPassada = Convert.ToDateTime(Console.ReadLine());
        }

        public static void CalcularTempo()
        {
            var diferencaTempo = DateTime.Now - DataPassada;
            int totalSeconds = Convert.ToInt32(diferencaTempo.TotalSeconds);

            anos = totalSeconds / 365 / 24 / 60 / 60;
            totalSeconds %= 60 * 60 * 24 * 365;

            meses = totalSeconds / 30 / 24 / 60 / 60;
            totalSeconds %= 60 * 24 * 60 * 30;

            semanas = totalSeconds / 7 / 24 / 60 / 60;
            totalSeconds %= 7 * 24 * 60 * 60;

            dias = totalSeconds / 24 / 60 / 60;
            totalSeconds %= 24 * 60 * 60;

            horas = totalSeconds / 60 / 60;
            totalSeconds %= 60 * 60;

            minutos = totalSeconds / 60;
            totalSeconds %= 60;

            segundos = totalSeconds;
        }

        public static string MostrarMensagem()
        {
            if (anos >= 1)
            {
                Mensagem += $"{anos} anos ";
            }
            
            if (meses >= 1)
            {
                Mensagem += $"{meses} meses ";
            }

            if (semanas >= 1)
            {
                Mensagem += $"{semanas} semanas ";
            }

            if (dias >= 1)
            {
                Mensagem += $"{dias} dias ";
            }

            if (horas >= 1)
            {
                Mensagem += $"{horas} horas ";
            }

            if (minutos >= 1)
            {
                Mensagem += $"{minutos} minutos ";
            }
            
            return Mensagem + "atras";
        }
    }
}