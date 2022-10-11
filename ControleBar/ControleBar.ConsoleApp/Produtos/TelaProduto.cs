using ControleBar.ConsoleApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleBar.ConsoleApp.Produtos
{
    public class TelaProduto : TelaBase, ITelaCadastravel
    {
        public readonly IRepositorio<Produto> repositorioProduto;
        private readonly Notificador _notificador;

        public TelaProduto(IRepositorio<Produto> repositorioProduto, Notificador notificador) : base ("Tela de produtos")
        {
            this.repositorioProduto = repositorioProduto;
            _notificador = notificador;
        }

        public void Editar()
        {
            MostrarTitulo("Editando Produto");

            bool temRegistrosCadastrados = VisualizarRegistros("Pesquisando");

            if (temRegistrosCadastrados == false)
            {
                _notificador.ApresentarMensagem("Nenhum produto cadastrado para editar.", TipoMensagem.Atencao);
                return;
            }

            int numeroGenero = ObterNumeroRegistro();

            Produto produtoAtualizado = ObterProduto();

            bool conseguiuEditar = repositorioProduto.Editar(numeroGenero, produtoAtualizado);

            if (!conseguiuEditar)
                _notificador.ApresentarMensagem("Não foi possível editar.", TipoMensagem.Erro);
            else
                _notificador.ApresentarMensagem("Produto editado com sucesso!", TipoMensagem.Sucesso);
        }

        public void Excluir()
        {
            MostrarTitulo("Excluindo Produto");

            bool temProdutosRegistrados = VisualizarRegistros("Pesquisando");

            if (temProdutosRegistrados == false)
            {
                _notificador.ApresentarMensagem("Nenhum produto cadastrado para excluir.", TipoMensagem.Atencao);
                return;
            }

            int numeroProduto = ObterNumeroRegistro();

            bool conseguiuExcluir = repositorioProduto.Excluir(numeroProduto);

            if (!conseguiuExcluir)
                _notificador.ApresentarMensagem("Não foi possível excluir.", TipoMensagem.Erro);
            else
                _notificador.ApresentarMensagem("Produto excluído com sucesso!", TipoMensagem.Sucesso);
        }

        private int ObterNumeroRegistro()
        {
            int numeroRegistro;
            bool numeroRegistroEncontrado;

            do
            {
                Console.Write("Digite o ID do produto que deseja selecionar: ");
                numeroRegistro = Convert.ToInt32(Console.ReadLine());

                numeroRegistroEncontrado = repositorioProduto.ExisteRegistro(numeroRegistro);

                if (numeroRegistroEncontrado == false)
                    _notificador.ApresentarMensagem("ID do garçom não foi encontrado, digite novamente", TipoMensagem.Atencao);

            } while (numeroRegistroEncontrado == false);

            return numeroRegistro;
        }

        public void Inserir()
        {
            MostrarTitulo("Cadastro de Produto");

            Produto novoProduto = ObterProduto();

            repositorioProduto.Inserir(novoProduto);

            _notificador.ApresentarMensagem("Produto cadastrado com sucesso!", TipoMensagem.Sucesso);
        }

        private Produto ObterProduto()
        {
            Produto produto = new Produto();
            ++produto.id;

            Console.Write("Insira o nome do produto: ");
            produto.Nome = Console.ReadLine();

            Console.Write("Insira o valor do produto: ");
            decimal valor = Convert.ToDecimal(Console.ReadLine());

            produto.Valor = valor;

            return produto;
        }

        public bool VisualizarRegistros(string tipoVisualizacao)
        {
            if (tipoVisualizacao == "Tela")
                MostrarTitulo("Visualização de produtos Cadastrados");

            List<Produto> produtos = repositorioProduto.SelecionarTodos();

            if (produtos.Count == 0)
            {
                _notificador.ApresentarMensagem("Nenhum produto disponível.", TipoMensagem.Atencao);
                return false;
            }

            foreach (Produto produto in produtos)
                Console.WriteLine(produto.ToString());

            Console.ReadLine();

            return true;
        }
    }
}
