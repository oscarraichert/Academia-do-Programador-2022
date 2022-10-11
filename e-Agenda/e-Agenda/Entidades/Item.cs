using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda.Entidade
{
    public class Item
    {
        public string Descricao;
        public bool Concluido;
        public Tarefa Tarefa;

        public Item()
        {

        }

        public Item(string descricao)
        {
            Descricao = descricao;
            Concluido = false;
        }

        public override string ToString()
        {
            return $"{Descricao}\n" +
                $"Concluído: {Concluido}";
        }
    }
}