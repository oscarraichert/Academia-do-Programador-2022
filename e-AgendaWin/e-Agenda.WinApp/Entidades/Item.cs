namespace e_Agenda.WinApp
{
    public class Item
    {
        public string Descricao;
        public bool Concluido;

        public override string ToString()
        {
            string concluido = "";

            if (Concluido == true)
            {
                concluido = "Sim";
            }

            else if (Concluido == false)
            {
                concluido = "Não";
            }

            return $"{Descricao}, Concluído: {concluido}";
        }
    }
}
