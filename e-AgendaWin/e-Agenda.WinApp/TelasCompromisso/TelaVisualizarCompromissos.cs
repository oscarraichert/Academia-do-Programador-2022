using e_Agenda.WinApp.Entidades;
using e_Agenda.WinApp.Repositorios;
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
    public partial class TelaVisualizarCompromissos : Form
    {
        public TelaVisualizarCompromissos(RepositorioCompromisso repositorioCompromisso)
        {
            InitializeComponent();
            MostrarCompromissos(repositorioCompromisso.Compromissos);
        }

        public void MostrarCompromissos(List<Compromisso> lista)
        {
            foreach (Compromisso compromisso in lista)
            {
                lblListaCompromissos.Text += $"\nAssunto: {compromisso.Assunto}" +
                    $"\nLocal: {compromisso.Local}" +
                    $"\nData: {compromisso.Data}" +
                    $"\nInício: {compromisso.HoraInicio}:{compromisso.MinutosInicio}" +
                    $"\nEncerramento: {compromisso.HoraTermino}:{compromisso.MinutosTermino}" +
                    $"\nContato: {compromisso.Contato.Nome}" +
                    $"\n  ";
            }
        }
    }
}
