using GeradorDeTestes.WinApp.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeradorDeTestes.WinApp.Telas.Telas_Alternativas
{
    public partial class TelaNovaAlternativa : Form
    {
        public Questao Questao;

        public TelaNovaAlternativa(Questao questao)
        {
            InitializeComponent();
            Questao = questao;
            radioButtonErrada.Checked = true;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            bool valida = AdicionarAlternativa();

            if (valida)
            {
                Close();
            }
        }

        private bool AdicionarAlternativa()
        {
            Alternativa novaAlternativa = new Alternativa();

            if (textBoxDescricao.Text == "")
            {
                MessageBox.Show("Você precisa inserir uma descrição!");
                return false;
            }

            novaAlternativa.Descricao = textBoxDescricao.Text;
            novaAlternativa.Correta = VerificarCorreta();

            Questao.Alternativas.Add(novaAlternativa);

            return true;
        }

        private bool VerificarCorreta()
        {
            if (radioButtonCerta.Checked)
            {
                return true;
            }

            else return false;
        }
    }
}