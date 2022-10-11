using ControleBar.ConsoleApp.Compartilhado;
using ControleBar.ConsoleApp.ModuloGarcom;
using ControleBar.ConsoleApp.Produtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleBar.ConsoleApp
{
    public class Conta : EntidadeBase
    {
        public Garcom Garcom;
        public List<Produto> Produtos;
        public decimal Valor;
        public bool Aberta;

        public Conta(Garcom garcom)
        {
            Garcom = garcom;
            Produtos = null;
            Valor = 0;
            Aberta = false;
        }

        public override string ToString()
        {
            return $"Garçom responsável: {Garcom.Nome}" +
                $"\nProdutos: {Produtos}" +
                $"\nValor: {Valor}" +
                $"\nAberta: {Aberta}";
        }
    }
}
