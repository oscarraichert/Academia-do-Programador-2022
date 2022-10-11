using e_Agenda.Telas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda
{
    public class TelaPrincipal
    {

        static TelaTarefas telaTarefas = new();
        static TelaContatos telaContatos = new();
        static TelaCompromissos telaCompromissos = new(telaContatos);

        public void MenuPrincipal()
        {
            string opcao = "";

            while (opcao != "s")
            {
                Compartilhado.NovaTela("e-Agenda:");

                Console.WriteLine("1- Tarefas" +
                    "\n2- Contatos" +
                    "\n3- Compromissos" +
                    "\ns- Sair");

                opcao = Console.ReadLine().ToLower();

                switch (opcao)
                {
                    case "s":
                        break;

                    default: Console.WriteLine("Comando inválido!");
                        break;

                    case "1":
                        telaTarefas.Menu("Tarefas:");
                        break;

                    case "2":
                        telaContatos.Menu("Contatos: ");
                        break;

                    case "3":
                        telaCompromissos.Menu("Compromissos: ");
                        break;
                }
            }
        }

        public void Fechando(object sender, EventArgs e)
        {
            telaTarefas.repositorioBase.Salvar();
            telaContatos.repositorioBase.Salvar();
            telaCompromissos.repositorioBase.Salvar();
        }
    }
}
