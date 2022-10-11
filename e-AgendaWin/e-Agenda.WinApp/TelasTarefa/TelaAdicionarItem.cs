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
    public partial class TelaAdicionarItem : Form
    {
        public Tarefa Tarefa;

        public TelaAdicionarItem(Tarefa tarefa)
        {
            InitializeComponent();
            Tarefa = tarefa;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            string descricao = textBoxDescricao.Text;
            Item item = new Item();
            item.Descricao = descricao;

            Tarefa.Itens.Add(item);
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
