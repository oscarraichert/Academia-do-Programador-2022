using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestesDonaMariana.WinApp.Entidades;
using TestesDonaMariana.WinApp.Repositorios;
using TestesDonaMariana.WinApp.Telas.Questoes;

namespace TestesDonaMariana.WinApp.ConfiguracoesMenu
{
    public class MenuQuestaoConfig : IMenuConfig<Questao>
    {
        public RepositorioBase<Questao> Repositorio { get; }

        public string Titulo { get; }

        public Form TelaCadastro { get; }

        public MenuQuestaoConfig()
        {
            Repositorio = new();
            Titulo = "Questões";
            TelaCadastro = new TelaCadastroQuestao(Repositorio);
        }
    }
}