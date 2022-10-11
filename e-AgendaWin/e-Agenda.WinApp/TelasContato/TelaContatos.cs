using e_Agenda.WinApp.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_Agenda.WinApp.TelasContato
{
    public partial class TelaContatos : Form
    {
        public TelaAdicionarContato telaAdicionarContatos;
        public RepositorioContato repositorioContato;
        public TelaVisualizarContatos telaVisualizarContatos;

        public TelaContatos()
        {
            repositorioContato = new();            
            InitializeComponent();
            AtualizarLista();
        }

        private void AtualizarLista()
        {
            listBoxContatos.Items.Clear();

            foreach (Contato contato in repositorioContato.Contatos)
            {
                listBoxContatos.Items.Add(contato);
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            telaAdicionarContatos = new();

            TelaAdicionarContato tela = telaAdicionarContatos;

            tela.ShowDialog();

            if (telaAdicionarContatos.DialogResult == DialogResult.OK)
            {
                Contato contato = telaAdicionarContatos.contato;

                repositorioContato.AdicionarContato(contato);

                AtualizarLista();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Contato contato = (Contato)listBoxContatos.SelectedItem;

            repositorioContato.RemoverContato(contato);

            AtualizarLista();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int indice = repositorioContato.Contatos.IndexOf((Contato)listBoxContatos.SelectedItem);

            telaAdicionarContatos = new();

            TelaAdicionarContato tela = telaAdicionarContatos;

            tela.ShowDialog();

            if (telaAdicionarContatos.DialogResult == DialogResult.OK)
            {
                Contato contato = telaAdicionarContatos.contato;

                repositorioContato.Contatos[indice] = contato;

                AtualizarLista();
            }
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            telaVisualizarContatos = new(repositorioContato);
            telaVisualizarContatos.ShowDialog();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}