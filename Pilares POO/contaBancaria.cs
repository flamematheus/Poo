using System;
using System.Collections.Generic;
using System.Text;

namespace Pilares_POO
{
    internal class ContaBancaria
    {
        public string Titular;
        private double Saldo;

        public void Depositar(double valor)
        {
            if (valor < 0)
            {
                Console.WriteLine("valor invalido! m");
            }

            Saldo += valor;
            Console.WriteLine($"Saldo Atualizado para :{Saldo}");
        }
    }
}
