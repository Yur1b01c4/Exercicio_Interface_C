using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Interface
{
    public abstract class Documento(string titulo)
    {
        public string Titulo { get; set; } = titulo;

        public void ExibirTitulo()
        {
            Console.WriteLine($"Título do Documento: {Titulo}");
        }

        public abstract void Processar();
    }
}
