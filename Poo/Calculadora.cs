using System;
using System.Collections.Generic;
using System.Text;

namespace Poo
{
    public class Calculadora
    {


        //metodos
        // mostrar as informaçoes do carro

        public int Somar (int A, int B)
        {

            return A + B;


        }
        public int Subtrair(int A, int B)
        {

            return A - B;

        }
        public void MostrarResultado(int valor)
        {
            Console.WriteLine($"mostrar resultadod :{valor}");
        }

    }
}
