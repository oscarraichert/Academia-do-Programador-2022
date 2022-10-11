using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura2._0.Telas
{
    public class TelaEmprestimos : SubTela<Emprestimo>
    {
        private TelaAmigos subTelaAmigos;
        private TelaRevistas subTelaRevistas;

        public TelaEmprestimos(TelaAmigos subTelaAmigos, TelaRevistas subTelaRevistas)
        {
            this.subTelaAmigos = subTelaAmigos;
            this.subTelaRevistas = subTelaRevistas;
        }

        protected override Emprestimo PegarEntidade()
        {
            Tela.Titulo("Digite as informações do empréstimo:");

            subTelaAmigos.Visualizar(limpar : false);

            Console.Write("\nSelecione o amigo: ");
            int indice = Convert.ToInt32(Console.ReadLine()) - 1;

            Amigo amigo = subTelaAmigos.Controlador.Lista[indice];

            Tela.Titulo("Amigo selecionado!");
            
            subTelaRevistas.Visualizar(limpar : false);

            Console.Write("\nSelecione a revista: ");
            int indiceRevista = Convert.ToInt32(Console.ReadLine()) - 1;

            Revista revista = subTelaRevistas.Controlador.Lista[indiceRevista];

            Tela.Titulo("Revista selecionada!");

            Console.Write("Data do empréstimo: ");
            string dataEmprestimo = Console.ReadLine();

            Console.Write("Data da devolução: ");
            string dataDevolucao = Console.ReadLine();

            Emprestimo emprestimo = new Emprestimo(amigo, revista, dataEmprestimo, dataDevolucao);

            return emprestimo;
        }
    }
}
