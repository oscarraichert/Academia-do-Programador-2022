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
    public partial class TelaItensTarefa : Form
    {
        public Tarefa tarefa;

        public TelaItensTarefa(Tarefa tarefa)
        {
            InitializeComponent();
            this.tarefa = tarefa;
            MostrarTarefa();
            MostrarItens();
        }

        public void MostrarTarefa()
        {
            lblTitulo.Text = tarefa.Titulo;
        }

        public void MostrarItens()
        {
            listBoxItens.Items.Clear();

            foreach (Item item in tarefa.Itens)
            {
                listBoxItens.Items.Add(item);
            }
        }

        private void btnAdicionarItem_Click(object sender, EventArgs e)
        {
            TelaAdicionarItem telaAdicionarItem = new TelaAdicionarItem(tarefa);

            telaAdicionarItem.ShowDialog();

            if (telaAdicionarItem.DialogResult == DialogResult.OK)
            {
                AtualizarPercentualConcluido();
                MostrarItens();
            }
        }

        private void btnConcluirItem_Click(object sender, EventArgs e)
        {
            if (listBoxItens.SelectedItem != null)
            {
                Item item = (Item)listBoxItens.SelectedItem;
                item.Concluido = true;
                AtualizarPercentualConcluido();
                MostrarItens();
            }

            else MessageBox.Show("Selecione um item para concluí-lo."); return;
        }

        private void AtualizarPercentualConcluido()
        {
            tarefa.PercentualConcluído = 0;

            double percentual = 0;

            for (double i = 0; i <= tarefa.Itens.Count; i++)
            {
                percentual = 100 / i;
            }

            foreach (Item item in tarefa.Itens)
            {
                if (item.Concluido)
                {
                    tarefa.PercentualConcluído += percentual;
                }
            }
        }

        private void btnExcluirItem_Click(object sender, EventArgs e)
        {
            if (listBoxItens.SelectedItem != null)
            {
                Item item = (Item)listBoxItens.SelectedItem;
                tarefa.Itens.Remove(item);
                MostrarItens();
            }

            else MessageBox.Show("Selecione um item para remover."); return;
        }
    }
}
