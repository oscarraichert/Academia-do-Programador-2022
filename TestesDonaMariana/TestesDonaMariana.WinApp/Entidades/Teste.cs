using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestesDonaMariana.WinApp.Entidades
{
    public enum Disciplina
    {
        Matematica, Portugues, Geografia, Historia
    }

    public class Teste : EntidadeBase<Teste>
    {
        public int Numero;
        public int NumeroQuestoes;
        public Disciplina Disciplina;
        public DateTime DataGeracao;
        public List<Questao> Questoes;
    }
}