using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda.Telas
{
    public static class Compartilhado
    {
        public static void NovaTela(string titulo)
        {
            Console.Clear();

            Titulo(titulo);
        }

        public static void Titulo(string titulo)
        {
            Console.WriteLine(titulo);

            Console.WriteLine();
        }
    }
}
