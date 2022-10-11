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
    public partial class TelaVisualizarContatos : Form
    {
        public TelaVisualizarContatos(RepositorioContato repositorioContato)
        {
            InitializeComponent();
            VisualizarContatos(repositorioContato.Contatos);
        }

        private void VisualizarContatos(List<Contato> contatos)
        {
            string lista = "";

            foreach (Contato contato in contatos)
            {
                lista += $"\n{contato.Nome}" +
                    $"\nE-Mail: {contato.Email}" +
                    $"\nTelefone: {contato.Telefone}" +
                    $"\nEmpresa: {contato.Empresa}" +
                    $"\nCargo: {contato.Cargo}" +
                    $"\n  ";
            }

            lblContatos.Text = lista;
        }
    }
}
