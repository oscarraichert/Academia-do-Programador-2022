using e_Agenda.WinApp.Repositorios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_Agenda.WinApp.TelasTarefa
{
    public partial class TelaVisualizarTarefas : Form
    {
        public TelaVisualizarTarefas(RepositorioTarefa repositorioTarefa)
        {
            InitializeComponent();
            MostrarTarefas(repositorioTarefa.Tarefas);
        }

        private void MostrarTarefas(List<Tarefa> lista)
        {
            string x = "";
            string y = "";

            foreach (Tarefa tarefa in lista)
            {
                if (tarefa.Prioridade == Prioridade.Alta && tarefa.PercentualConcluído < 100)
                {
                    x += $"\nTarefa {tarefa.Numero}: {tarefa.Titulo}" +
                        $"\nPrioridade: {tarefa.Prioridade}" +
                        $"\nData de Criação: {tarefa.DataCriacao}" +
                        $"\n{tarefa.PercentualConcluído}% concluída.\n   ";
                }
            }

            foreach (Tarefa tarefa in lista)
            {
                if (tarefa.Prioridade == Prioridade.Normal && tarefa.PercentualConcluído < 100)
                {
                    x += $"\nTarefa {tarefa.Numero}: {tarefa.Titulo}" +
                        $"\nPrioridade: {tarefa.Prioridade}" +
                        $"\nData de Criação: {tarefa.DataCriacao}" +
                        $"\n{tarefa.PercentualConcluído}% concluída.\n   ";
                }
            }

            foreach (Tarefa tarefa in lista)
            {
                if (tarefa.Prioridade == Prioridade.Baixa && tarefa.PercentualConcluído < 100)
                {
                    x += $"\nTarefa {tarefa.Numero}: {tarefa.Titulo}" +
                        $"\nPrioridade: {tarefa.Prioridade}" +
                        $"\nData de Criação: {tarefa.DataCriacao}" +
                        $"\n{tarefa.PercentualConcluído}% concluída.\n   ";
                }
            }

            foreach (Tarefa tarefa in lista)
            {
                if (tarefa.PercentualConcluído >= 100)
                {
                    y += $"\nTarefa {tarefa.Numero}: {tarefa.Titulo}" +
                        $"\nPrioridade: {tarefa.Prioridade}" +
                        $"\nData de Criação: {tarefa.DataCriacao}" +
                        $"\n{tarefa.PercentualConcluído}% concluída." +
                        $"\nData de conclusão: {tarefa.DataConclusao}" +
                        $"\n   ";
                }
            }

            lblConcluidas.Text = y;

            lblListaTarefas.Text = x;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
