using System;
using System.Collections.Generic;
using System.Text;

namespace Poo
{
    public class Conversor
    {
        //metodos
        // mostrar as informaçoes do carro

        public double CelsiusParaFahrenheit(double celsius)
        {

            return celsius * 1.8 +32;


        }
        public bool EstaQuente(double celcius)
        {
            return  (celcius >= 30 == true) ;
        }

    }
}
