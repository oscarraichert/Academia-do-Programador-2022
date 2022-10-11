using e_Agenda.WinApp.Entidades;
using System.Collections.Generic;

namespace e_Agenda.WinApp.TelasContato
{
    public class RepositorioContato
    {
        public List<Contato> Contatos;
        public int Contador = 0;

        public RepositorioContato()
        {
            Contatos = new List<Contato>();
        }

        public void AdicionarContato(Contato contato)
        {
            Contatos.Add(contato);

            contato.Numero = ++Contador;
        }

        public void RemoverContato(Contato contato)
        {
            Contatos.Remove(contato);
        }
    }
}