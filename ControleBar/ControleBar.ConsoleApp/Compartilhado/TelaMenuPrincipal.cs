using ControleBar.ConsoleApp.Contas;
using ControleBar.ConsoleApp.ModuloGarcom;
using ControleBar.ConsoleApp.ModuloMesa;
using ControleBar.ConsoleApp.Produtos;
using System;

namespace ControleBar.ConsoleApp.Compartilhado
{
    public class TelaMenuPrincipal
    {
        private readonly IRepositorio<Garcom> repositorioGarcom;
        private readonly TelaCadastroGarcom telaCadastroGarcom;
        private readonly IRepositorio<Mesa> repositorioMesa;
        private readonly TelaMesa telaMesa;
        private readonly IRepositorio<Produto> repositorioProduto;
        private readonly TelaProduto telaProduto;
        private readonly TelaConta telaConta;

        public TelaMenuPrincipal(Notificador notificador)
        {
            repositorioGarcom = new RepositorioGarcom();
            telaCadastroGarcom = new TelaCadastroGarcom(repositorioGarcom, notificador);
            repositorioMesa = new RepositorioMesa();
            telaMesa = new TelaMesa(repositorioMesa, notificador);
            repositorioProduto = new RepositorioProduto();
            telaProduto = new TelaProduto(repositorioProduto, notificador);
            telaConta = new TelaConta(notificador, telaCadastroGarcom, telaMesa, telaProduto);

            PopularAplicacao();
        }



        public string MostrarOpcoes()
        {
            Console.Clear();

            Console.WriteLine("Controle de Mesas de Bar 1.0");

            Console.WriteLine();

            Console.WriteLine("Digite 1 para Gerenciar Garçons");

            Console.WriteLine("Digite 2 para Gerenciar Mesas");

            Console.WriteLine("Digite 3 para Gerenciar Produtos");

            Console.WriteLine("Digite 4 para Gerenciar Contas");

            Console.WriteLine("Digite s para sair");

            string opcaoSelecionada = Console.ReadLine();

            return opcaoSelecionada;
        }

        public TelaBase ObterTela()
        {
            string opcao = MostrarOpcoes();

            TelaBase tela = null;

            if (opcao == "1")
                tela = telaCadastroGarcom;

            else if (opcao == "2")
                tela = telaMesa;

            else if (opcao == "3")
                tela = telaProduto;

            else if (opcao == "4")
                tela = telaConta;

            else if (opcao == "5")
                tela = null;

            return tela;
        }

        private void PopularAplicacao()
        {
            var garcom = new Garcom("Julinho", "230.232.519-98");
            var garcom2 = new Garcom("Carlos", "00473982749");
            var garcom3 = new Garcom("Ricardo", "84792657394");
            repositorioGarcom.Inserir(garcom);
            repositorioGarcom.Inserir(garcom2);
            repositorioGarcom.Inserir(garcom3);
        }
    }
}
