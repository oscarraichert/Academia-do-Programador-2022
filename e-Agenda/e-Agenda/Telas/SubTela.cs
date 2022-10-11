using e_Agenda.Repositórios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda.Telas
{
    public abstract class SubTela<T>
    {
        public RepositorioBase<T> repositorioBase = new();
        public static readonly string NomeEntidade = typeof(T).Name;

        public void Menu(string titulo)
        {
            string opcao = "";

            while (opcao != "s")
            {
                Compartilhado.NovaTela(titulo);

                Console.WriteLine("1- Inserir" +
                    "\n2- Editar" +
                    "\n3- Excluir" +
                    "\n4- Visualizar" +
                    "\ns- Sair");

                opcao = Console.ReadLine().ToLower();

                switch (opcao)
                {
                    case "s": break;

                    default:
                        Console.WriteLine("Opção Inválida!");
                        break;

                    case "1":
                        CadastrarEntidade();
                        break;

                    case "2":
                        EditarEntidade();
                        break;

                    case "3":
                        ExcluirEntidade();
                        break;

                    case "4":
                        VisualizarEntidades(input : true);
                        break;
                }
            }
        }

        private void EditarEntidade()
        {
            Compartilhado.NovaTela($"Editando {NomeEntidade}");

            VisualizarEntidades(input : false);

            Console.Write($"Selecionar {NomeEntidade}: ");
            int indice = Convert.ToInt32(Console.ReadLine()) - 1;
            EditarEntidade(indice);
        }

        private void EditarEntidade(int indice)
        {
            T entidade = ObterEntidade();
            repositorioBase.AlterarEntidade(indice, entidade);
        }

        private void ExcluirEntidade()
        {
            Compartilhado.NovaTela($"Excluindo {NomeEntidade}");

            VisualizarEntidades(input : false);

            Console.WriteLine($"Selecione o(a) {NomeEntidade} que deseja excluir: ");
            int indice = Convert.ToInt32(Console.ReadLine()) - 1;

            T entidade = repositorioBase.Entidades[indice];

            repositorioBase.RemoverEntidade(entidade);
        }

        public virtual void VisualizarEntidades(bool input)
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
        }             

        public void CadastrarEntidade()
        {
            repositorioBase.InserirEntidade(ObterEntidade());
        }

        public abstract T ObterEntidade();
    }
}