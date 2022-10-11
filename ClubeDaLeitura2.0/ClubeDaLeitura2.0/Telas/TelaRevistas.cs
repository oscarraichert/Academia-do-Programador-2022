using System;

namespace ClubeDaLeitura2._0
{
    public class TelaRevistas: SubTela<Revista>
    {
        private TelaCaixas subTelaCaixas;

        public TelaRevistas(TelaCaixas subTelaCaixas)
        {
            this.subTelaCaixas = subTelaCaixas;
        }
        protected override Revista PegarEntidade()
        {
            Tela.Titulo("Digite as informações da revista:");
        
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
        
            Console.Write("Coleção: ");
            string colecao = Console.ReadLine();
        
            Console.Write("Edição: ");
            string edicao = Console.ReadLine();
        
            Console.Write("Ano: ");
            string ano = Console.ReadLine();
        
            Tela.Titulo("Procurando caixas....");
            subTelaCaixas.Visualizar(limpar: false);
        
            Console.Write("\nSelecione a caixa da revista: ");
            int indice = Convert.ToInt32(Console.ReadLine()) - 1;
        
            Caixa caixa = subTelaCaixas.Controlador.Lista[indice];
        
            Revista revista = new Revista(nome, colecao, edicao, ano, caixa);
        
            return revista;
        }
    }
}