using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda.WinApp.Repositorios
{
    public class RepositorioTarefa
    {
        public List<Tarefa> Tarefas;
        public int Contador = 0;

        public RepositorioTarefa()
        {
            Tarefas = new List<Tarefa>();
        }

        public void AdicionarTarefa(Tarefa tarefa)
        {
            Tarefas.Add(tarefa);

            tarefa.Numero = ++Contador;
        }
    }
}
