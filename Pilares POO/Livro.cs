using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Pilares_POO
{
    public class Livro
    {
        public string Titulo;
        public string Autor;

        public int Paginas;

        public Livro(string Titulo,string Autor,int Paginas)
        {
            this.Titulo = Titulo;
            this.Autor = Autor;
            this.Paginas = Paginas;
        }
        public void Exibir()
        {
            Console.WriteLine($"livros:");
        }
    }
}
