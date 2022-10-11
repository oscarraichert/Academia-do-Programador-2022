using System.Windows.Forms;
using TestesDonaMariana.WinApp.Entidades;
using TestesDonaMariana.WinApp.Repositorios;
using TestesDonaMariana.WinApp.Telas;

namespace TestesDonaMariana.WinApp
{
    internal class MenuTesteConfig : IMenuConfig<Teste>
    {
        public RepositorioBase<Teste> Repositorio { get; }

        public string Titulo { get; }

        public Form TelaCadastro { get; }

        public MenuTesteConfig()
        {
            Repositorio = new();
            Titulo = "Testes";
            TelaCadastro = new TelaCadastroTeste(Repositorio);
        }
    }
}