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

namespace TestesDonaMariana.WinApp.Telas
{
    public partial class TelaCadastroTeste : Form
    {
        public RepositorioBase<Teste> Repositorio { get; }
        public Teste Teste;

        public TelaCadastroTeste(RepositorioBase<Teste> repositorio)
        {
            InitializeComponent();
            Repositorio = repositorio;
            Teste = new();

        }


    }
}
