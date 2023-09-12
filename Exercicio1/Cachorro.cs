using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    public class Cachorro : Animal, ICachorro
    {
        public Cachorro(string raca, double peso, string porte, string cor) : base(raca, peso, porte, cor)
        {
        }

        public void Latir()
        {
            Console.WriteLine("Latindo!");
        }

        public void Obedecer()
        {
            Console.WriteLine("Obedencendo!");
        }

        
    }
}
