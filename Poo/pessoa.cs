using System;
using System.Collections.Generic;
using System.Text;

namespace Poo
{
    public class pessoa
    {
        //atributos 
        public string Nome;
        public int Idade;
   
        //metodos
        // mostrar as informaçoes do carro

        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu {Nome} é Ana e tenho {Idade}");
         
            
        }
    }
}
