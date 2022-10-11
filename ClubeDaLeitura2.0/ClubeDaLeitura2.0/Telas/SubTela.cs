using System.ComponentModel;
using System;
using System.Reflection;

namespace ClubeDaLeitura2._0
{
    public class SubTela<T>
    {
        public Controlador<T> Controlador = new Controlador<T>();

        public void SubMenu()
        {
            string opcao = "";

            while (opcao != "S")
            {
                Tela.Titulo($"Opções {typeof(T).Name}s: ");

                Console.WriteLine("1 - Inserir:" +
                    "\n2 - Editar:" +
                    "\n3 - Excluir:" +
                    "\n4 - Visualizar:" +
                    "\nS - Sair.");

                opcao = Console.ReadLine().ToUpper();

                switch (opcao)
                {
                    case "1":
                        Inserir();
                        break;

                    case "2":
                        Editar();
                        break;

                    case "3":
                        Excluir();
                        break;

                    case "4":
                        bool limpar = true;
                        Visualizar(limpar);
                        break;
                }
            }
        }

        private void Excluir()
        {
            Tela.Titulo($"Excluindo {typeof(T).Name}:");

            Console.WriteLine($"Selecione o {typeof(T).Name} que deseja excluir: ");

            bool limpar = false;
            Visualizar(limpar);

            int indice = Convert.ToInt32(Console.ReadLine()) - 1;

            Controlador.Exluir(indice);
        }

        public void Editar()
        {
            Tela.Titulo($"Editando {typeof(T).Name}:");

            Console.WriteLine($"Selecione o {typeof(T).Name} que deseja editar: ");

            bool limpar = false;
            Visualizar(limpar);

            int indice = Convert.ToInt32(Console.ReadLine()) - 1;

            T entidade = PegarEntidade();

            Controlador.Editar(indice, entidade);
        }

        public void Visualizar(bool limpar)
        {
            if (limpar)
            {
                Tela.Titulo($"Lista de {typeof(T).Name}s cadastrados:");
            }

            for (int i = 0; i < Controlador.Lista.Count; i++)
            {
                Console.WriteLine($"\nNúmero: {i + 1}\n{Controlador.Lista[i]}");
            }

            if (limpar)
            {
                Console.ReadKey();
            }
        }

        public void Inserir()
        {
            T entidade = PegarEntidade();
            Controlador.Inserir(entidade);
        }

        protected virtual T PegarEntidade()
        {
            var campos = typeof(T).GetProperties();
            T entidade = CriarEntidadeVazia();

            foreach (PropertyInfo campo in campos)
            {
                Console.Write($"{NomeAtributo(campo)}: ");
                string valor = Console.ReadLine();
                campo.SetValue(entidade, Converter(valor, campo.PropertyType));
            }

            return entidade;
        }

        private static string NomeAtributo(PropertyInfo campo)
        {
            return campo.GetCustomAttribute<DisplayNameAttribute>()?.DisplayName?? campo.Name;
        }

        private static T CriarEntidadeVazia()
        {
            return (T)Activator.CreateInstance(typeof(T));
        }

        private object Converter(string valor, Type tipo)
        {
            return Convert.ChangeType(valor, tipo);
        }
    }
}