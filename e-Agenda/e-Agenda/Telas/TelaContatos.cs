using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda.Telas
{
    public class TelaContatos : SubTela<Contato>
    {
        public TelaContatos()
        {

        }

        public override Contato ObterEntidade()
        {
            Compartilhado.NovaTela("Cadastrando novo contato: ");

            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("E-mail: ");
            string email = Console.ReadLine();

            Console.Write("Telefone: ");
            string telefone = Console.ReadLine();

            Console.Write("Empresa: ");
            string empresa = Console.ReadLine();

            Console.Write("Cargo: ");
            string cargo = Console.ReadLine();

            Contato contato = new(nome, email, telefone, empresa, cargo);

            return contato;
        }
    }
}
