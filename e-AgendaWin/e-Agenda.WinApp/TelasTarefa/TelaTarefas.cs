using e_Agenda.WinApp.Repositorios;
using e_Agenda.WinApp.TelasTarefa;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_Agenda.WinApp
{
    public partial class TelaTarefas : Form
    {
        public TelaCadastroTarefa telaCadastro = new();
        public TelaItensTarefa telaItens;
        public TelaVisualizarTarefas telaVisualizar;

        public TelaTarefas()
        {
            InitializeComponent();
        }

        private void MostrarTarefas(List<Tarefa> lista)
        {
            listTarefas.Items.Clear();

            foreach (Tarefa tarefa in lista)
            {
                if (tarefa.PercentualConcluído < 100)
                {
                    listTarefas.Items.Add(tarefa);
                }                
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            telaCadastro.ShowDialog();
            if (telaCadastro.DialogResult == DialogResult.OK)
            {
                telaCadastro.repositorioTarefa.AdicionarTarefa(telaCadastro.tarefa);
                MostrarTarefas(telaCadastro.repositorioTarefa.Tarefas);
            }
        }

        private void btnItens_Click(object sender, EventArgs e)
        {
            if (listTarefas.SelectedItem != null)
            {
                Tarefa tarefa = (Tarefa)listTarefas.SelectedItem;

                telaItens = new(tarefa);

                telaItens.ShowDialog();

                if (telaItens.DialogResult == DialogResult.OK)
                {
                    if (tarefa.PercentualConcluído == 100)
                    {
                        tarefa.DataConclusao = DateTime.Now;
                    }
                    MostrarTarefas(telaCadastro.repositorioTarefa.Tarefas);
                }
            }

            else MessageBox.Show("Selecione uma tarefa."); return;
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            telaVisualizar = new(telaCadastro.repositorioTarefa);
            telaVisualizar.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Tarefa tarefa = (Tarefa)listTarefas.SelectedItem;
            int numero = tarefa.Numero;
            DateTime data = tarefa.DataCriacao;

            int indice = telaCadastro.repositorioTarefa.Tarefas.IndexOf(tarefa);

            telaCadastro.ShowDialog();

            if (telaCadastro.DialogResult == DialogResult.OK)
            {
                telaCadastro.repositorioTarefa.Tarefas[indice] = telaCadastro.tarefa;
                telaCadastro.tarefa.Numero = numero;
                telaCadastro.tarefa.DataCriacao = data;
            }

            MostrarTarefas(telaCadastro.repositorioTarefa.Tarefas);
        }

        private void bntExcluir_Click(object sender, EventArgs e)
        {
            Tarefa tarefa = (Tarefa)listTarefas.SelectedItem;

            telaCadastro.repositorioTarefa.Tarefas.Remove(tarefa);

            MostrarTarefas(telaCadastro.repositorioTarefa.Tarefas);
        }

        private void btnConcluir_Click(object sender, EventArgs e)
        {
            Tarefa tarefa = (Tarefa)listTarefas.SelectedItem;

            tarefa.PercentualConcluído = 100;

            tarefa.DataConclusao = DateTime.Now;

            MostrarTarefas(telaCadastro.repositorioTarefa.Tarefas);
        }
    }
}