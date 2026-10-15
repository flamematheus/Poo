using System;
using System.Collections.Generic;
using System.Text;

namespace Poo
{
    public class Carro
    {
        //atributos 
        public string Marca;
        public string Modelo;
        public int Ano;

        //metodos
        // mostrar as informaçoes do carro

        public void ExibirIformacoes()
        {
            Console.WriteLine($"marca:{Marca}");
            Console.WriteLine($"modelo:{Modelo}");
            Console.WriteLine($"ano:{Ano}");
        }
    }
}
