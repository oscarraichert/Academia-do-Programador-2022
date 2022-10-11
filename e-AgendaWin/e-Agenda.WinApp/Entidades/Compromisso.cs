using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda.WinApp.Entidades
{
    public class Compromisso
    {
        public int Numero;
        public string Assunto;
        public string Local;
        public string Data;
        public int HoraInicio;
        public int MinutosInicio;
        public int HoraTermino;
        public int MinutosTermino;
        public Contato Contato;

        public Compromisso()
        {

        }

        public override string ToString()
        {
            return $"Compromisso: {Assunto}; " +
                $"\nData: {Data}";
        }
    }
}
