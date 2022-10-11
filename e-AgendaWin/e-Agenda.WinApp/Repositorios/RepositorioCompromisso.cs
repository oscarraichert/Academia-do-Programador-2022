using e_Agenda.WinApp.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda.WinApp.Repositorios
{
    public class RepositorioCompromisso
    {
        public List<Compromisso> Compromissos;
        public int Contador = 0;

        public RepositorioCompromisso()
        {
            Compromissos = new List<Compromisso>();
        }

        public void AdicionarCompromisso(Compromisso compromisso)
        {
            Compromissos.Add(compromisso);

            compromisso.Numero = ++Contador;
        }

        public void RemoverCompromisso(Compromisso compromisso)
        {
            Compromissos.Remove(compromisso);
        }
    }
}
