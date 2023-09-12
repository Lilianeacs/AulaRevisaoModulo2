using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    public class Animal : IAnimal
    {
        public string Raca { get; set; }   
        public double Peso { get; set; }
        public string Porte { get; set; }
        public string Cor { get; set; }

        public Animal(string raca, double peso, string porte, string cor)
        {
            Raca = raca;
            Peso = peso;
            Porte = porte;
            Cor = cor;
        }

        public void Comer()
        {
            Console.WriteLine("Comendo!");
        }

        public void Reproduzir()
        {
            Console.WriteLine("Reproduzindo!");
        }
    }
}
