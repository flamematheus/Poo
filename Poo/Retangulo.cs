using System;
using System.Collections.Generic;
using System.Text;

namespace Poo
{
    public class Retangulo
    {

        //atributos 
        public double Largura;
        public double Altura;

        //metodos
        // mostrar as informaçoes do carro

        public double CalcularArea()
        {
            double Aria = Largura * Altura;
            return Aria;


        }
        public double CalcularPerimetro()
        {
            double Perimetro = (2 * Largura) + (2* Altura);
            return Perimetro;


        }



    }
}

