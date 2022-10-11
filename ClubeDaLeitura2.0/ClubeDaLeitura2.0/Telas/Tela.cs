using ClubeDaLeitura2._0.Telas;
using System;

namespace ClubeDaLeitura2._0
{
    public class Tela
    {
        public TelaAmigos subTelaAmigos;
        public TelaCaixas subTelaCaixas;
        public TelaRevistas subTelaRevistas;
        public TelaEmprestimos subTelaEmprestimos;

        public Tela()
        {            
            subTelaAmigos = new();
            subTelaCaixas = new();
            subTelaRevistas = new(subTelaCaixas);
            subTelaEmprestimos = new(subTelaAmigos, subTelaRevistas);
        }

        public void Fechando(object sender, EventArgs e)
        {
            subTelaAmigos.Controlador.Salvar();
            subTelaCaixas.Controlador.Salvar();
            subTelaRevistas.Controlador.Salvar();
            subTelaEmprestimos.Controlador.Salvar();
        }

        public void MenuPrincipal()
        {
            string opcao = "";

            while (opcao != "S")
            {
                Titulo("Clube da Leitura 2.0: ");

                Console.WriteLine("1 - Amigos:" +
                    "\n2 - Caixas:" +
                    "\n3 - Revistas:" +
                    "\n4 - Emprestimo:" +
                    "\nS - Sair.");

                opcao = Console.ReadLine().ToUpper();

                switch (opcao)
                {
                    case "1":
                        subTelaAmigos.SubMenu();
                        break;

                    case "2":
                        subTelaCaixas.SubMenu();
                        break;

                    case "3":
                        subTelaRevistas.SubMenu();
                        break;

                    case "4":
                        subTelaEmprestimos.SubMenu();
                        break;

                    case "S":
                        break;
                        

                    default: break;
                }
            }
        }

        public static void Titulo(string titulo)
        {
            Console.Clear();

            Console.WriteLine($"{titulo}\n");
        }
    }
}