using ControleBar.ConsoleApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleBar.ConsoleApp.Produtos
{
    public class Produto: EntidadeBase
    {
        public string Nome;
        public decimal Valor;

        public override string ToString()
        {
            return $"Id: {id}" +
                $"\nProduto: {Nome}" +
                $"\nValor: {Valor}\n";
        }
    }
}
