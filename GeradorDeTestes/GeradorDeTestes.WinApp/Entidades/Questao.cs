using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeTestes.WinApp.Entidades
{
    public class Questao
    {
        public string Enunciado;
        public string Materia;
        public string Disciplina;
        public string Bimestre;
        public List<Alternativa> Alternativas;

        public Questao()
        {
            Alternativas = new List<Alternativa>();
        }

        public override string ToString()
        {
            return $"{Disciplina}, {Materia} - {Enunciado}";
        }
    }
}
