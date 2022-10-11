using GeradorDeTestes.WinApp.Entidades;
using GeradorDeTestes.WinApp.Repositorios;
using GeradorDeTestes.WinApp.Telas.Telas_Alternativas;
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
    public partial class TelaNovaQuestao : Form
    {
        public RepositorioQuestao RepositorioQuestao;
        public Questao Questao;

        public TelaNovaQuestao(RepositorioQuestao repositorioQuestao, Questao editarQuestao)
        {
            InitializeComponent();
            CriarOuEditarQuestao(editarQuestao);
            RepositorioQuestao = repositorioQuestao;
        }

        private void CriarOuEditarQuestao(Questao editarQuestao)
        {
            if (editarQuestao != null)
            {
                Questao = editarQuestao;
                textBoxEnunciado.Text = editarQuestao.Enunciado;
                textBoxMateria.Text = editarQuestao.Materia;
                comboBoxBimestre.Text = editarQuestao.Bimestre;
                comboBoxDisciplina.Text = editarQuestao.Disciplina;
                AtualizarListBox();
            }

            else Questao = new Questao();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            PreencherQuestao();
            bool valido = ValidarCamposQuestao();

            if (valido)
            {
                RepositorioQuestao.Questoes.Add(Questao);
                Close();
            }            
        }

        private bool ValidarCamposQuestao()
        {
            if (Questao.Enunciado == "" || Questao.Materia == "" || Questao.Disciplina == ""
                            || Questao.Bimestre == "" || Questao.Alternativas == null)
            {
                MessageBox.Show("Você precisa preencher todos os dados!");
                return false;
            }

            if (Questao.Alternativas.Count < 4)
            {
                MessageBox.Show("A questão precisa ter no mínimo 4 alternativas!");
                return false;
            }

            int i = 0;
            int j = 0;

            foreach (Alternativa alternativa in Questao.Alternativas)
            {
                if (alternativa.Correta)
                {
                    ++i;
                }

                if (alternativa.Correta == false)
                {
                    ++j;
                }
            }

            if (i < 1 || j < 3)
            {
                MessageBox.Show("A questão precisa de pelo menos uma Alternativa correta e três erradas!");
                return false;
            }

            return true;
        }

        private void PreencherQuestao()
        {
            Questao.Enunciado = textBoxEnunciado.Text;
            Questao.Materia = textBoxMateria.Text;
            Questao.Disciplina = comboBoxDisciplina.Text;
            Questao.Bimestre = comboBoxBimestre.Text;
        }

        private void btnAdicionarAlternativa_Click(object sender, EventArgs e)
        {
            TelaNovaAlternativa telaNovaAlternativa = new TelaNovaAlternativa(Questao);

            telaNovaAlternativa.ShowDialog();

            AtualizarListBox();
        }

        private void AtualizarListBox()
        {
            listBoxAlternativas.Items.Clear();

            foreach (Alternativa alternativa in Questao.Alternativas)
            {
                listBoxAlternativas.Items.Add(alternativa);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Alternativa alternativa = (Alternativa)listBoxAlternativas.SelectedItem;

            Questao.Alternativas.Remove(alternativa);

            AtualizarListBox();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}