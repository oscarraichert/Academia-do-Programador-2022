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

namespace e_Agenda.WinApp.TelasTarefa
{
    public partial class TelaCadastroTarefa : Form
    {
        public RepositorioTarefa repositorioTarefa;
        public Tarefa tarefa;

        public TelaCadastroTarefa()
        {
            repositorioTarefa = new RepositorioTarefa();
            InitializeComponent();
            radiobtnNormal.Checked = true;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string titulo = txtboxTitulo.Text;

            string descricao = txtboxDescricao.Text;

            Prioridade prioridade = Prioridade.Normal;

            if (radiobtnAlta.Checked)
            {
                prioridade = Prioridade.Alta;
            }

            else if (radiobtnNormal.Checked)
            {
                prioridade = Prioridade.Normal;
            }

            else if (radiobtnBaixa.Checked)
            {
                prioridade = Prioridade.Baixa;
            }

            tarefa = new();
            tarefa.Prioridade = prioridade;
            tarefa.Titulo = titulo;
            tarefa.Descrição = descricao;
            tarefa.DataCriacao = DateTime.Now;
            tarefa.Itens = new List<Item>();
        }
    }
}
