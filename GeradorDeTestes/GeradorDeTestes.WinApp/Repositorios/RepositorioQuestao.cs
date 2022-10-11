using GeradorDeTestes.WinApp.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeTestes.WinApp.Repositorios
{
    public class RepositorioQuestao
    {
        public List<Questao> Questoes;

        public RepositorioQuestao()
        {
            Questoes = new List<Questao>();
        }
    }
}
