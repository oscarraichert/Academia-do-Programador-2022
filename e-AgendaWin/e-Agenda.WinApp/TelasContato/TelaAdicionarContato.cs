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
    public partial class TelaAdicionarContato : Form
    {
        public Contato contato;

        public TelaAdicionarContato()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            contato = new Contato();

            contato.Nome = textBoxNome.Text;
            contato.Email = textBoxEmail.Text;
            contato.Telefone = textBoxTelefone.Text;
            contato.Empresa = textBoxEmpresa.Text;
            contato.Cargo = textBoxCargo.Text;
        }
    }
}
