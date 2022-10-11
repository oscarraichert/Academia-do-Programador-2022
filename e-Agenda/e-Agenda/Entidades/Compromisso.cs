using e_Agenda.Telas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Para cada compromisso, armazenar: Assunto, local, data do compromisso, hora de início e término. A maioria dos
compromissos estão relacionados com algum contato de sua agenda.

possibilidade de registrar novos compromissos, editar e excluir os já existentes;
possibilidade de visualizar os compromissos que já passaram e que vão acontecer de forma
separada.*/

namespace e_Agenda.Entidades
{
    public class Compromisso
    {
        public string Assunto;
        public string Local;
        public DateTime Data;
        public string HoraInicio;
        public string HoraTermino;
        public Contato Contato;

        public Compromisso(string assunto, string local, DateTime data, string horaInicio, string horaTermino, Contato contato)
        {
            Assunto = assunto;
            Local = local;
            Data = data;
            HoraInicio = horaInicio;
            HoraTermino = horaTermino;
            Contato = contato;
        }

        public Compromisso()
        {

        }

        public override string ToString()
        {
            return $"Compromisso com {Contato.Nome}" +
                $"\nAssunto: {Assunto}" +
                $"\nLocal: {Local}" +
                $"\nData: {Data.Date}" +
                $"\nHorário: {HoraInicio} - {HoraTermino}";
        }
    }
}
