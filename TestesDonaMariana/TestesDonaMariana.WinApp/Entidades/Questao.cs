using System.Collections.Generic;

namespace TestesDonaMariana.WinApp.Entidades
{
    public class Questao: EntidadeBase<Questao>
    {
        public string Descricao;
        public string Materia;
        public List<Alternativa> Alternativas;
        public Disciplina Disciplina;

        public Questao()
        {
            Alternativas = new List<Alternativa>();
        }

        public override string ToString()
        {
            return $"{Disciplina} - {Descricao}";
        }
    }
}