using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda.WinApp.Entidades
{
    public class Contato
    {
        public int Numero;
        public string Nome;
        public string Email;
        public string Telefone;
        public string Empresa;
        public string Cargo;

        public Contato()
        {
            
        }

        public override string ToString()
        {
            return $"{Nome}; Telefone: {Telefone}";
        }
    }
}
