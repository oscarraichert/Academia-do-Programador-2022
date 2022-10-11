using ControleBar.ConsoleApp.Compartilhado;
using ControleBar.ConsoleApp.Produtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleBar.ConsoleApp.Pedidos
{
    public class Pedido : EntidadeBase
    {
        public List<Produto> Produtos;
    }
}
