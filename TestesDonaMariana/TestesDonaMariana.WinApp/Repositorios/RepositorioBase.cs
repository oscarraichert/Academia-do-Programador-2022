using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestesDonaMariana.WinApp.Entidades;

namespace TestesDonaMariana.WinApp.Repositorios
{
    public class RepositorioBase<T>
    {
        public List<T> Lista;

        public RepositorioBase()
        {
            Lista = new List<T>();
        }

        internal void AdicionarItem(T item)
        {
            Lista.Add(item);
        }
    }
}
