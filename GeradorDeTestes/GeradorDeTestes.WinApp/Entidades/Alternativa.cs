using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeTestes.WinApp.Entidades
{
    public class Alternativa
    {
        public string Descricao;
        public bool Correta;

        private string FormatarStringCorreta()
        {
            if (Correta)
            {
                return "Certa";
            }

            else return "Errada";
        }

        public override string ToString()
        {
            return $"{Descricao} - {FormatarStringCorreta()}";
        }
    }
}
