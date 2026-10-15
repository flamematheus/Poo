using System;
using System.Collections.Generic;
using System.Text;

namespace Pilares_POO
{
    public class Viagem
    {
            public string Destino;
            public int Dias;

            public  double ValorDiaria;

            public Viagem(string Destino, int Dias, double ValorDiaria)
            {
                this.Destino = Destino;
                this.Dias = Dias;
                this.ValorDiaria = ValorDiaria;
            }

        public double  CalcularTotal()
        {
            return Dias * ValorDiaria;
        }

        public void Exibir()
        {
            Console.WriteLine($" viagem {CalcularTotal()}");
        }
     }
}
