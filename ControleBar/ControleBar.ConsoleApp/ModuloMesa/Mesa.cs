using ControleBar.ConsoleApp.Compartilhado;
using ControleBar.ConsoleApp.ModuloGarcom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleBar.ConsoleApp.ModuloMesa
{
    public class Mesa :  EntidadeBase
    {
        public string NumeroMesa { get; set; }

        public Mesa()
        {

        }

        public override string ToString()
        {
            return $"Indice: {id}" +
                $"\nNúmero: {NumeroMesa}";
        }
    }
}
