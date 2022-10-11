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
using TestesDonaMariana.WinApp.Repositorios;
using TestesDonaMariana.WinApp.Telas.Questoes;

namespace TestesDonaMariana.WinApp.Telas
{
    public partial class TelaMenuBase<T> : Form
    {              
        public IMenuConfig<T> MenuConfig { get; }     

        public TelaMenuBase(IMenuConfig<T> menuConfig)
        {
            InitializeComponent();
            MenuConfig = menuConfig;
            ConfigurarTela();
            AtualizarListBox();
        }

        private void ConfigurarTela()
        {
            this.Text = $"Menu de {MenuConfig.Titulo}";
            btnNovoCadastro.Text = $"Novo(a) {typeof(T).Name}";
            btnEditarCadastro.Text = $"Editar {MenuConfig.Titulo}";
            btnExcluirCadastro.Text = $"Excluir {typeof(T).Name}";
            btnVisualizar.Text = $"Visualizar Tudo";
        }

        private void btnNovoCadastro_Click(object sender, EventArgs e)
        {
            var tela = MenuConfig.TelaCadastro;            

            tela.ShowDialog();

            if (tela.DialogResult == DialogResult.OK)
            {                
                AtualizarListBox();
            }
        }

        private void AtualizarListBox()
        {
            listBoxCadastros.Items.Clear();

            foreach (T item in MenuConfig.Repositorio.Lista)
            {
                listBoxCadastros.Items.Add(item);
            }
        }

        private void btnExcluirCadastro_Click(object sender, EventArgs e)
        {
            T item = (T)listBoxCadastros.SelectedItem;

            MenuConfig.Repositorio.Lista.Remove(item);

            AtualizarListBox();
        }
    }
}
