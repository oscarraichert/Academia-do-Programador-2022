namespace TestesDonaMariana.WinApp.Entidades
{
    public class Alternativa: EntidadeBase<Alternativa>
    {
        public string Descricao;
        public bool Correta;

        public Alternativa(string descricao)
        {
            Descricao = descricao;
            Correta = false;
        }

        public override string ToString()
        {
            return $"{Descricao}";
        }
    }
}