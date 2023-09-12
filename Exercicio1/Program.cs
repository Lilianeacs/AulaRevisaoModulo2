namespace Exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICachorro cachorro = new Cachorro("pug", 8, "pequeno", "areia");
            IGato gato = new Gato("Siames", 5, "pequeno", "cinza");
            IPassaro passaro = new Passaro("Canarinho", 0.2, "pequeno", "amarelo");

            List<IAnimal> lista = new List<IAnimal>();
            lista.Add(cachorro);
            lista.Add(gato);
            lista.Add(passaro);

            foreach (Animal animal in lista) 
            {
                Console.WriteLine(animal.Raca);
                animal.Reproduzir();
                animal.Comer();
                Console.WriteLine();
            }

            Console.WriteLine();
            cachorro.Latir();
            cachorro.Obedecer();
            Console.WriteLine();
            gato.Miar();
            gato.Obedecer();
            Console.WriteLine();
            passaro.voar();
        }
    }
}


/*
 * Crie uma ou mais inteface para criarmos as seguintes estruturas:

Classe Passaro
com método Comer, Reproduzir, Voar

Classe Cachorro
com método Comer, Latir, Reproduzir, Obedecer

Classe Gato
com método Obedecer, Reproduzir, Comer
*/