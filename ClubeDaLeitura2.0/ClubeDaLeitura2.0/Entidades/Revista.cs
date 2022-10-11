namespace ClubeDaLeitura2._0
{
    public class Revista
    {
        public string Nome { get; set; }    
        public string Colecao { get; set; }
        public string Edicao { get; set; }
        public string Ano { get; set; }
        public Caixa Caixa { get; set; }

        public Revista(string nome, string colecao, string edicao, string ano, Caixa caixa)
        {
            Nome = nome;
            Colecao = colecao;
            Edicao = edicao;
            Ano = ano;
            Caixa = caixa;
        }

        public Revista()
        {

        }

        public override string ToString()
        {
            return $"Nome: {Nome}" +
                $"\nColeção: {Colecao}" +
                $"\nEdição: {Edicao}" +
                $"\nAno: {Ano}" +
                $"\nCaixa: {Caixa.Cor}";
        }
    }
}