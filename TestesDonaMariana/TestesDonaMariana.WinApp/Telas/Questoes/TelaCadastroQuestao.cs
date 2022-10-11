using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestesDonaMariana.WinApp.Entidades;
using TestesDonaMariana.WinApp.Repositorios;

namespace TestesDonaMariana.WinApp.Telas.Questoes
{
    public partial class TelaCadastroQuestao : Form
    {
        public RepositorioBase<Questao> Repositorio { get; }
        public Questao Questao;

        public TelaCadastroQuestao(RepositorioBase<Questao> repositorio)
        {
            InitializeComponent();
            Repositorio = repositorio;
            Questao = new Questao();
            LimparAlternativas();
            ConfigurarComboBox();
            AtualizarListBox();
        }

        private void LimparAlternativas()
        {
            Questao.Alternativas.Clear();
        }

        private void ConfigurarComboBox()
        {
            comboBoxDisciplina.Items.Clear();
            comboBoxDisciplina.Items.Add(Disciplina.Geografia);
            comboBoxDisciplina.Items.Add(Disciplina.Matematica);
            comboBoxDisciplina.Items.Add(Disciplina.Portugues);
            comboBoxDisciplina.Items.Add(Disciplina.Historia);            
        }

        private void btnAdicionarAlternativa_Click(object sender, EventArgs e)
        {
            TelaCadastroAlternativas telaAlternativas = new TelaCadastroAlternativas();
            telaAlternativas.ShowDialog();

            if (telaAlternativas.DialogResult == DialogResult.OK)
            {
                Questao.Alternativas.Add(telaAlternativas.alternativa);
                AtualizarListBox();
            }
        }

        private void AtualizarListBox()
        {
            listBoxAlternativas.Items.Clear();

            foreach (Alternativa alternativa in Questao.Alternativas)
            {
                listBoxAlternativas.Items.Add(alternativa);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (textBoxDescricao.Text == "" || textBoxMateria.Text == "" || listBoxAlternativas.Items.Count == 0 
                || comboBoxDisciplina.SelectedItem == null)
            {
                MessageBox.Show("Os campos não podem ser vazios!");
                Questao.Alternativas.Clear();
                ResetarTela();
                LimparAlternativas();
                return;
            }

            var alternativas = new List<Alternativa>();

            alternativas = Questao.Alternativas;

            Questao = new();
            Questao.Descricao = textBoxDescricao.Text;
            Questao.Materia = textBoxMateria.Text;
            Questao.Disciplina = SelecionarDisciplina();
            Questao.Alternativas = alternativas;

            Repositorio.AdicionarItem(Questao);

            LimparAlternativas();

            ResetarTela();
        }

        private Disciplina SelecionarDisciplina()
        {
             return (Disciplina)comboBoxDisciplina.SelectedItem;
        }

        private void ResetarTela()
        {
            comboBoxDisciplina.SelectedItem = null;
            textBoxDescricao.Text = null;
            textBoxMateria.Text = null;
            AtualizarListBox();
        }

        private void btnExcluirAlternativa_Click(object sender, EventArgs e)
        {
            Alternativa alternativa = (Alternativa)listBoxAlternativas.SelectedItem;

            Questao.Alternativas.Remove(alternativa);

            AtualizarListBox();
        }
    }
}
