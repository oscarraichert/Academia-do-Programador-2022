using System.ComponentModel;

namespace ClubeDaLeitura2._0
{
    public class Amigo
    {
        public string Nome { get; set; }
        [DisplayName("Nome do Responsável")]
        public string NomeResponsavel { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }

        public Amigo(string nome, string nomeResponsavel, string endereco, string telefone)
        {
            Nome = nome;
            NomeResponsavel = nomeResponsavel;
            Endereco = endereco;
            Telefone = telefone;            
        }

        public Amigo()
        {

        }

        public override string ToString()
        {
            return $"Nome: {Nome}" +
                $"\nTelefone: {Telefone}";
        }
    }
}