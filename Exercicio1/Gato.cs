using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    public class Gato : Animal, IGato
    {
        public Gato(string raca, double peso, string porte, string cor) : base(raca, peso, porte, cor)
        {
        }

        public void Miar()
        {
            Console.WriteLine("Miauuu!");
        }

        public void Obedecer()
        {
            Console.WriteLine("Obedencendo!");
        }

    }
}
