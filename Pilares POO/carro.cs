using System;
using System.Collections.Generic;
using System.Text;

namespace Pilares_POO
{
    internal class Carro
    {
        public string Marca;
        public string Modelo;

        // Metodo Construtor
        // Não tem tipo de retorno
        // Tem o mesmo nome da classe
        public Carro(string marca, string modelo)
        {
            //Receber uma marca e um modelo
            this.Marca = marca;
            this.Modelo = modelo;
        }
    }
}
 
 
