using GeradorDeTestes.WinApp.Entidades;
using GeradorDeTestes.WinApp.Repositorios;
using GeradorDeTestes.WinApp.Telas.Telas_Questoes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeradorDeTestes.WinApp
{
    public partial class TelaGeradorTestes : Form
    {
        TelaMenuQuestoes MenuQuestoes;
        RepositorioQuestao RepositorioQuestao;

        public TelaGeradorTestes()
        {
            RepositorioQuestao = new RepositorioQuestao();
            MenuQuestoes = new TelaMenuQuestoes(RepositorioQuestao);
            InitializeComponent();
        }

        private void btnQuestoes_Click(object sender, EventArgs e)
        {
            MenuQuestoes.ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();    
        }

        private void btnGerarTeste_Click(object sender, EventArgs e)
        {
            GerarTeste();
        }

        private void GerarTeste()
        {
            var questoes = RepositorioQuestao.Questoes;
            
            if (questoes.Count > Convert.ToInt32(textBoxNumeroQuestoes.Text))
            {
                SelecionarQuestoes();
            } 
        }

        private void SelecionarQuestoes()
        {
            int numQuestoes = Convert.ToInt32(textBoxNumeroQuestoes.Text);

            Random random = new Random();

            List<Questao> questoes = new List<Questao>();

            foreach (Questao quest in RepositorioQuestao.Questoes)
            {
                if (quest.Disciplina == comboBoxDisciplina.Text)
                {
                    questoes.Add(quest);
                }
            }

            foreach (Questao quest in questoes)
            {

            }
        }
    }
}