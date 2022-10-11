using System.ComponentModel;

namespace ClubeDaLeitura2._0
{
    public class Emprestimo
    {
        public Amigo Amigo { get; set; }
        public Revista Revista { get; set; }
        [DisplayName("Data do empréstimo")]
        public string DataEmprestimo { get; set; }
        [DisplayName("Data da devolução")]
        public string DataDevolucao { get; set; }

        public Emprestimo()
        {

        }

        public Emprestimo(Amigo amigo, Revista revista, string dataEmprestimo, string dataDevolucao)
        {
            Amigo = amigo;
            Revista = revista;
            DataEmprestimo = dataEmprestimo;
            DataDevolucao = dataDevolucao;
        }

        public override string ToString()
        {
            return $"Amigo: {Amigo.Nome}" +
                $"\nRevista: {Revista.Nome}" +
                $"\nData de empréstimo: {DataEmprestimo}" +
                $"\nData da devolução: {DataDevolucao}";
        }
    }
}