using System;
using System.Collections.Generic;
using System.Text;

namespace Poo
{
    //classes -moldes
    public class Pedido
    {
            //atributos 
            public string NomeDoCiente;
            public double Preço;
            public string Item;
            public int Quantidade;

            //metodos
            // mostrar as informaçoes do carro

            public void ExibirDados()
            {
                Console.WriteLine($"Nome do cliente:{NomeDoCiente}");
                Console.WriteLine($"Preço:{Preço}");
                Console.WriteLine($"Item:{Item}");
                Console.WriteLine($"Quantidade:{Quantidade}");
            
            }
     }
    
}
