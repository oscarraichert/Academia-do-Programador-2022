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

namespace TestesDonaMariana.WinApp.Telas.Questoes
{
    public partial class TelaCadastroAlternativas : Form
    {
        public Alternativa alternativa;

        public TelaCadastroAlternativas()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            string descricao = textBoxDescricao.Text;

            alternativa = new(descricao);

            if (radioButtonCerta.Checked == true)
            {
                alternativa.Correta = true;
            }
        }
    }
}
