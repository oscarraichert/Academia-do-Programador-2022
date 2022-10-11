namespace e_Agenda.Telas
{
    public class Contato
    {
        public string Nome;
        public string Email;
        public string Telefone;
        public string Empresa;
        public string Cargo;

        public Contato(string nome, string email, string telefone, string empresa, string cargo)
        {
            Nome = nome;
            Email = email;
            Telefone = telefone;
            Empresa = empresa;
            Cargo = cargo;
        }

        public Contato()
        {

        }

        public override string ToString()
        {
            return $"\nNome: {Nome}" +
                $"\nE-mail: {Email}" +
                $"\nTelefone: {Telefone}" +
                $"\nEmpresa: {Empresa}" +
                $"\nCargo: {Cargo}";
        }
    }
}