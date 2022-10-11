using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestesDonaMariana.WinApp.ConfiguracoesMenu;
using TestesDonaMariana.WinApp.Entidades;
using TestesDonaMariana.WinApp.Repositorios;
using TestesDonaMariana.WinApp.Telas;

namespace TestesDonaMariana.WinApp
{
    public partial class TelaPrincipal : Form
    {
        public IMenuConfig<Questao> menuConfigQuestao;
        public TelaMenuBase<Questao> telaMenuQuest;
        public TelaMenuBase<Teste> telaMenuTeste;
        public IMenuConfig<Teste> menuConfigTeste;

        public TelaPrincipal()
        {
            menuConfigQuestao = new MenuQuestaoConfig();
            menuConfigTeste = new MenuTesteConfig();
            InitializeComponent();
        }

        private void btnMenuTestes_Click(object sender, EventArgs e)
        {
            telaMenuTeste = new TelaMenuBase<Teste>(menuConfigTeste);
            telaMenuTeste.ShowDialog();
        }

        private void btnQuestoes_Click(object sender, EventArgs e)
        {
            telaMenuQuest = new TelaMenuBase<Questao>(menuConfigQuestao);
            telaMenuQuest.ShowDialog();
        }
    }
}
