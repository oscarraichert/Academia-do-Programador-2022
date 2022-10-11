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

namespace GeradorDeTestes.WinApp.Telas.Telas_Questoes
{
    public partial class TelaDetalhesQuestao : Form
    {
        public Questao Questao;
        public TelaDetalhesQuestao(Questao questao)
        {
            InitializeComponent();
            Questao = questao;
            ConfigurarTela();
        }

        private void ConfigurarTela()
        {
            lblQuestao.Text = $"Questao: {Questao.Disciplina}, {Questao.Materia} ({Questao.Bimestre} Bimestre) - {Questao.Enunciado}" +
                $"\n\nAlternativas: \n{MostrarAlternativas()} ";
        }

        private string MostrarAlternativas()
        {
            string txt = "";

            foreach (Alternativa alternativa in Questao.Alternativas)
            {
                txt += $"\n{alternativa}\n";
            }

            return txt;
        }
    }
}
