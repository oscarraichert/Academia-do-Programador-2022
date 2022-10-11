using e_Agenda.Entidade;
using System;
using System.Collections.Generic;

namespace e_Agenda
{
    public class Tarefa
    {
        public enum Prioridade
        {
            Alta, Normal, Baixa
        }

        public string Titulo;
        public Prioridade StatusPrioridade;
        public List<Item> Itens;
        public DateTime DataCriacao;
        public DateTime DataConclusao;
        public double PercentualConcluido;

        public Tarefa()
        {

        }

        public Tarefa(string titulo, Prioridade statusPrioridade)
        {
            Titulo = titulo;
            StatusPrioridade = statusPrioridade;
            Itens = new();
            DataCriacao = DateTime.Now;
            PercentualConcluido = 0;
        }

        internal void AdicionarItem(Item item)
        {
            Itens.Add(item);
        }

        public void VerificarConclusao()
        {
            var percItem = 100 / Itens.Count;

            foreach (var item in Itens)
            {
                if (item.Concluido == true)
                {
                    PercentualConcluido += percItem;
                }
            }
        }

        public override string ToString()
        {
            return $"Título: {Titulo}" +
                $"\nPrioridade: {StatusPrioridade}" +
                $"\nConcluído: {PercentualConcluido}%" +
                $"\nData de criação: {DataCriacao}";
        }
    }
}