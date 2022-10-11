using System;
using System.Collections.Generic;

namespace e_Agenda.WinApp
{
    public enum Prioridade
    {
        Alta, Normal, Baixa
    }

    public class Tarefa
    {
        public int Numero;
        public string Titulo;
        public string Descrição;
        public Prioridade Prioridade;
        public DateTime DataCriacao;
        public DateTime DataConclusao;
        public List<Item> Itens;
        public double PercentualConcluído;

        public Tarefa()
        {
            
        }

        public override string ToString()
        {
            return $"Tarefa {Numero}: {Titulo}.";
        }
    }
}
