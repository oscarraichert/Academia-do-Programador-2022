using e_Agenda.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda.Telas
{
    public class TelaItens : SubTela<Item>
    {
        public Tarefa Tarefa { get; set; }

        public TelaItens()
        {
        }

        public override Item ObterEntidade()
        {
            Compartilhado.NovaTela("Novo item da tarefa:");

            Console.Write("Descrição: ");
            string descricao = Console.ReadLine();

            Console.WriteLine();

            Item item = new(descricao);

            return item;
        }        
    }
}