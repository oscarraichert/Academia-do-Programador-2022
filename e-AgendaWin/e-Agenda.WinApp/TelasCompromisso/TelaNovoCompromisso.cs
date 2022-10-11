using e_Agenda.WinApp.Entidades;
using e_Agenda.WinApp.TelasContato;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_Agenda.WinApp.TelasCompromisso
{
    public partial class TelaNovoCompromisso : Form
    {
        public TelaContatos telaContatos;
        public Compromisso compromisso;

        public TelaNovoCompromisso(TelaContatos telaContatos)
        {
            this.telaContatos = telaContatos;
            InitializeComponent();
            MostrarContatos();
        }

        private void MostrarContatos()
        {
            List<Contato> contatos = telaContatos.repositorioContato.Contatos;

            listBoxContatos.Items.Clear();

            foreach (Contato contato in contatos)
            {
                listBoxContatos.Items.Add(contato);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            compromisso = new();

            compromisso.Assunto = textBoxAssunto.Text;
            compromisso.Local = textBoxLocal.Text;
            compromisso.Data = textBoxData.Text;
            compromisso.HoraInicio = Convert.ToInt32(textBoxHoraIhrs.Text);
            compromisso.MinutosInicio = Convert.ToInt32(textBoxHoraImin.Text);
            compromisso.HoraTermino = Convert.ToInt32(textBoxTerminoHrs.Text);
            compromisso.MinutosTermino = Convert.ToInt32(textBoxMinutosTermino.Text);

            compromisso.Contato = (Contato)listBoxContatos.SelectedItem;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
