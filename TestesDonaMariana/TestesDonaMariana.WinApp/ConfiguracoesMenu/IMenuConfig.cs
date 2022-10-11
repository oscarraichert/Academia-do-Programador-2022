using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestesDonaMariana.WinApp.Repositorios;

namespace TestesDonaMariana.WinApp
{
    public interface IMenuConfig<T>
    {
        RepositorioBase<T> Repositorio { get; }
        string Titulo { get; }
        Form TelaCadastro { get; }
    }
}
