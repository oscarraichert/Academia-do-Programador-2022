using e_Agenda.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda.Telas
{
    public class TelaCompromissos : SubTela<Compromisso>
    {
        public TelaContatos TelaContatos;

        public TelaCompromissos(TelaContatos telaContatos)
        {
            TelaContatos = telaContatos;
        }

        public override Compromisso ObterEntidade()
        {
            Compartilhado.NovaTela("Cadastrando novo compromisso: ");

            TelaContatos.VisualizarEntidades(false);
            Console.Write("Selecione o contato do compromisso: ");

            Contato contato = TelaContatos.repositorioBase.Entidades[Convert.ToInt32(Console.ReadLine()) - 1];
            Console.WriteLine();

            Console.Write("Assunto: ");
            string assunto = Console.ReadLine();

            Console.Write("Local: ");
            string local = Console.ReadLine();

            Console.Write("Data: ");
            DateTime data = Convert.ToDateTime(Console.ReadLine());

            Console.Write("Hora inicio: ");
            string horaI = Console.ReadLine();

            Console.Write("Hora término: ");
            string horaT = Console.ReadLine();

            Compromisso compromisso = new Compromisso(assunto, local, data, horaI, horaT, contato);

            return compromisso;
        }
    }
}
