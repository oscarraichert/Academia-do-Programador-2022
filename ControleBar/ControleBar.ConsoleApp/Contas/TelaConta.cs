using ControleBar.ConsoleApp.Compartilhado;
using ControleBar.ConsoleApp.ModuloGarcom;
using ControleBar.ConsoleApp.ModuloMesa;
using ControleBar.ConsoleApp.Produtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleBar.ConsoleApp.Contas
{
    public class TelaConta : TelaBase
    {
        private readonly RepositorioConta repositorioConta;
        private readonly Notificador notificador;
        public TelaCadastroGarcom telaGarcomConta;
        public TelaMesa telaMesaConta;
        public TelaProduto telaProduto;

        public TelaConta(Notificador notificador, TelaCadastroGarcom telaGarcom, TelaMesa telaMesa, TelaProduto telaProduto) : base ("Tela Conta")
        {
            this.repositorioConta = new RepositorioConta();
            this.notificador = notificador;
            telaGarcomConta = telaGarcom;
            telaMesaConta = telaMesa;
            this.telaProduto = telaProduto;
        }

        public override string MostrarOpcoes()
        {
            MostrarTitulo("Tela Conta");

            Console.WriteLine("Digite 1 para Abrir Conta");
            Console.WriteLine("Digite 2 para Adicionar Produtos");
            Console.WriteLine("Digite 3 para Excluir");
            Console.WriteLine("Digite 4 para Visualizar");

            Console.WriteLine("Digite s para sair");

            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "s":
                    break;

                case "1":
                    Inserir();
                    break;

                case "2":
                    AdicionarProdutos();
                    break;

                case "4":
                    VisualizarRegistros("Tela");
                    break;
            }
            return "";
        }

        private void AdicionarProdutos()
        {
            VisualizarRegistros("Tela");

            Console.WriteLine("Selecione a conta que deseja adicionar produtos: ");

            int indice = Convert.ToInt32(Console.ReadLine()) - 1;

            Conta conta = repositorioConta.registros[indice];

            Console.WriteLine("Selecione o produto que deseja adicionar: ");

            telaProduto.VisualizarRegistros("Tela");

            int indiceProduto = Convert.ToInt32(Console.ReadLine()) - 1;

            Produto produto = telaProduto.repositorioProduto.SelecionarRegistro(indiceProduto);

            conta.Produtos.Add(produto); //tentei
        }

        public void Inserir()
        {
            Conta conta = AbrirConta();

            repositorioConta.registros.Add(conta);
        }

        public void Excluir()
        {
            throw new NotImplementedException();
        }

        public Conta AbrirConta()
        {
            MostrarTitulo("Abrindo Conta");
            
            telaGarcomConta.VisualizarRegistros("Tela");

            Console.WriteLine("Garçom responsável pela conta: ");


            int idGarcom = Convert.ToInt32(Console.ReadLine());

            Garcom garcom = telaGarcomConta._repositorioGarcom.SelecionarRegistro(idGarcom);

            Conta conta = new Conta(garcom);

            conta.Aberta = true;

            return conta;
        }

        private void MostrarTitulo(string titulo)
        {
            Console.Clear();

            Console.WriteLine(titulo);

            Console.WriteLine();
        }

        public bool VisualizarRegistros(string tipoVisualizacao)
        {
            if (tipoVisualizacao == "Tela")
                MostrarTitulo("Visualização de Contas Cadastrados");

            List<Conta> contas = repositorioConta.SelecionarTodos();

            if (contas.Count == 0)
            {
                notificador.ApresentarMensagem("Nenhuma conta disponível.", TipoMensagem.Atencao);
                return false;
            }

            foreach (Conta conta in contas)
                Console.WriteLine(conta.ToString());

            Console.ReadLine();

            return true;
        }
    }
}
