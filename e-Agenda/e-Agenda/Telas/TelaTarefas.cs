using e_Agenda.Entidade;
using e_Agenda.Repositórios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static e_Agenda.Tarefa;

namespace e_Agenda.Telas
{
    public class TelaTarefas : SubTela<Tarefa>
    {
        private TelaItens telaItens;

        public TelaTarefas()
        {
            telaItens = new TelaItens();
        }

        public override Tarefa ObterEntidade()
        {
            Compartilhado.NovaTela("Insira as informações da tarefa:");

            Console.Write("Título: ");
            string titulo = Console.ReadLine();

            Prioridade prioridade = ObterPrioridade();

            Tarefa tarefa = new(titulo, prioridade);

            telaItens.Tarefa = tarefa;
            AdicionarItensNaTarefa(tarefa, telaItens);

            return tarefa;
        }

        private static void AdicionarItensNaTarefa(Tarefa tarefa, TelaItens telaItens)
        {
            Compartilhado.NovaTela("Insira os itens necessários para completar a tarefa: ");

            string opcao = "";

            while (opcao != "s")
            {
                Console.WriteLine("1- Inserir novo item" +
                    "\ns- Sair");

                opcao = Console.ReadLine().ToLower();

                switch (opcao)
                {
                    case "s":
                        break;

                    default:
                        Console.WriteLine("Comando inválido!");
                        Console.ReadKey();
                        break;

                    case "1":
                        tarefa.AdicionarItem(telaItens.ObterEntidade());
                        break;
                }
            }
        }

        private Prioridade ObterPrioridade()
        {
            Console.Write("Status de prioridade: \n" +
                "\n1- Baixa" +
                "\n2- Normal" +
                "\n3- Alta\n");

            string opcao = Console.ReadLine();

            while (opcao != "1" && opcao != "2" && opcao != "3")
            {
                Console.WriteLine("Opção Inválida!");
                return ObterPrioridade();
            }

            switch (opcao)
            {
                default: throw new Exception("Sexo maluco exception!!!!!!");

                case "1":
                    return Prioridade.Baixa;

                case "2":
                    return Prioridade.Normal;

                case "3":
                    return Prioridade.Alta;
            }
        }

        public override void VisualizarEntidades(bool input)
        {
            string opcao = "";

            while (opcao != "s")
            {
                Compartilhado.NovaTela($"Lista de {NomeEntidade}");

                for (int i = 0; i < repositorioBase.Entidades.Count; i++)
                {
                    Console.WriteLine($"{NomeEntidade} {i + 1}\n{repositorioBase.Entidades[i]}\n");
                }

                if (input)
                {
                    Console.ReadKey();
                }

                Console.WriteLine("Selecionar a tarefa para visualizar seus itens" +
                                "\ns- Sair");

                opcao = Console.ReadLine().ToLower();

                if (opcao == "s")
                    break;

                Compartilhado.NovaTela("Opções de itens");

                Tarefa tarefa = repositorioBase.Entidades[Convert.ToInt32(opcao) - 1];

                Console.WriteLine($"{tarefa}");
                VisualizarItensDaTarefa(tarefa);

                OpcoesItem(tarefa);
            }
        }

        private static void VisualizarItensDaTarefa(Tarefa tarefa)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nItens a concluir: ");
            Console.ResetColor();
            
            for (int i = 0; i < tarefa.Itens.Count; i++)
            {
                if (tarefa.Itens[i].Concluido == false)
                {
                    Console.WriteLine($"\nItem {i + 1}\nDescrição: {tarefa.Itens[i]}\n");
                }
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Itens concluídos: \n");
            Console.ResetColor();

            for (int i = 0; i < tarefa.Itens.Count; i++)
            {
                if (tarefa.Itens[i].Concluido == true)
                {
                    Console.WriteLine($"Item {i + 1}\nDescrição: {tarefa.Itens[i]}\n");
                }
            }
        }

        public void OpcoesItem(Tarefa tarefa)
        {
            Console.WriteLine("1- Marcar item como concluído" +
                "\n2- Excluir item" +
                "\n3- Adicionar item" +
                "\ns- Sair");

            string opcaoAdd = Console.ReadLine();

            switch (opcaoAdd)
            {
                default:
                    break;

                case "s":
                    break;

                case "3":
                    tarefa.AdicionarItem(telaItens.ObterEntidade());
                    break;

                case "2":
                    ExcluirItemDaTarefa(tarefa);
                    break;

                case "1":
                    ConcluirItemDaTarefa(tarefa);
                    break;
            }
        }

        private static void ConcluirItemDaTarefa(Tarefa tarefa)
        {
            Console.Write("\nSelecione o item para marcar como concluído: ");
            int indiceItem = Convert.ToInt32(Console.ReadLine()) - 1;
            tarefa.Itens[indiceItem].Concluido = true;

            tarefa.VerificarConclusao();
        }

        private static void ExcluirItemDaTarefa(Tarefa tarefa)
        {
            Console.Write("\nSelecione o item para excluir: ");
            int indiceItem = Convert.ToInt32(Console.ReadLine()) - 1;
            tarefa.Itens.RemoveAt(indiceItem);
        }
    }
}