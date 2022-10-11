using ControleBar.ConsoleApp.Compartilhado;
using ControleBar.ConsoleApp.ModuloGarcom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleBar.ConsoleApp.ModuloMesa
{
    public class TelaMesa : TelaBase, ITelaCadastravel
    {
        private readonly IRepositorio<Mesa> _repositorioMesa;
        private readonly Notificador _notificador;

        public TelaMesa(IRepositorio<Mesa> repositorioMesa, Notificador notificador) : base("Cadastro de Mesas")
        {
            _repositorioMesa = repositorioMesa;
            _notificador = notificador;
        }

        public void Editar()
        {
            MostrarTitulo("Editando Mesa");

            bool temRegistrosCadastrados = VisualizarRegistros("Pesquisando");

            if (temRegistrosCadastrados == false)
            {
                _notificador.ApresentarMensagem("Nenhuma mesa cadastrada para editar.", TipoMensagem.Atencao);
                return;
            }

            int numeroGenero = ObterNumeroRegistro();

            Mesa mesaAtualizada = ObterMesa();

            bool conseguiuEditar = _repositorioMesa.Editar(numeroGenero, mesaAtualizada);

            if (!conseguiuEditar)
                _notificador.ApresentarMensagem("Não foi possível editar.", TipoMensagem.Erro);
            else
                _notificador.ApresentarMensagem("Mesa editada com sucesso!", TipoMensagem.Sucesso);
        }

        public void Excluir()
        {
            MostrarTitulo("Excluindo Mesa");

            bool temMesaRegistrada = VisualizarRegistros("Pesquisando");

            if (temMesaRegistrada == false)
            {
                _notificador.ApresentarMensagem("Nenhuma Mesa cadastrada para excluir.", TipoMensagem.Atencao);
                return;
            }

            int indiceMesa = ObterNumeroRegistro();

            bool conseguiuExcluir = _repositorioMesa.Excluir(indiceMesa);

            if (!conseguiuExcluir)
                _notificador.ApresentarMensagem("Não foi possível excluir.", TipoMensagem.Erro);
            else
                _notificador.ApresentarMensagem("Mesa excluída com sucesso!", TipoMensagem.Sucesso);
        }

        private int ObterNumeroRegistro()
        {
            Console.Write("\nSelecione o indice da mesa: ");

            int indice = Convert.ToInt32(Console.ReadLine());

            return indice;
        }

        public void Inserir()
        {
            MostrarTitulo("Cadastro da Mesa");

            Mesa novaMesa = ObterMesa();

            _repositorioMesa.Inserir(novaMesa);
        }

        public Mesa ObterMesa()
        {
            Mesa mesa = new();

            ++mesa.id;

            Console.WriteLine($"Indice da mesa: {mesa.id}");
            Console.WriteLine("Número da mesa: ");
            string numero = Console.ReadLine();


            mesa.NumeroMesa = numero;

            return mesa;
        }

        public bool VisualizarRegistros(string tipoVisualizacao)
        {
            if (tipoVisualizacao == "Tela")
                MostrarTitulo("Visualização de Mesas Cadastradas");

            List<Mesa> mesas = _repositorioMesa.SelecionarTodos();

            if (mesas.Count == 0)
            {
                _notificador.ApresentarMensagem("Nenhuma mesa disponível.", TipoMensagem.Atencao);
                return false;
            }

            foreach (Mesa mesa in mesas)
                Console.WriteLine(mesa.ToString());
            if (tipoVisualizacao == "Tela")
            {
                Console.ReadKey();

            }

            return true;
        }
    }
}
