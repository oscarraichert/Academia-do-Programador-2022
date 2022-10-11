using GeradorDeTestes.WinApp.Entidades;
using GeradorDeTestes.WinApp.Repositorios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeradorDeTestes.WinApp.Telas.Telas_Questoes
{
    public partial class TelaMenuQuestoes : Form
    {
        public RepositorioQuestao RepositorioQuestao;

        public TelaMenuQuestoes(RepositorioQuestao repositorioQuestao)
        {
            InitializeComponent();
            RepositorioQuestao = repositorioQuestao;
            AtualizarListBox();
        }

        private void btnAdicionarQuestao_Click(object sender, EventArgs e)
        {
            TelaNovaQuestao telaNovaQuestao = new TelaNovaQuestao(RepositorioQuestao, null);
            telaNovaQuestao.ShowDialog();

            AtualizarListBox();
        }

        private void AtualizarListBox()
        {
            listBoxQuestoes.Items.Clear();

            foreach (Questao questao in RepositorioQuestao.Questoes)
            {
                listBoxQuestoes.Items.Add(questao);
            }
        }

        private void btnExcluirQuestao_Click(object sender, EventArgs e)
        {
            Questao questao = (Questao)listBoxQuestoes.SelectedItem;

            RepositorioQuestao.Questoes.Remove(questao);

            AtualizarListBox();
        }

        private void btnEditarQuestao_Click(object sender, EventArgs e)
        {
            Questao questao = (Questao)listBoxQuestoes.SelectedItem;

            RepositorioQuestao.Questoes.Remove(questao);

            TelaNovaQuestao telaNovaQuestao = new TelaNovaQuestao(RepositorioQuestao, questao);

            telaNovaQuestao.ShowDialog();

            AtualizarListBox();
        }

        private void btnDetalhes_Click(object sender, EventArgs e)
        {
            Questao questao = (Questao)listBoxQuestoes.SelectedItem;

            if (questao != null)
            {
                TelaDetalhesQuestao telaDetalhes = new TelaDetalhesQuestao(questao);
                telaDetalhes.ShowDialog();
            }
        }
    }
}
