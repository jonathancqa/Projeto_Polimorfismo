using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoologico.src
{
    public class Zebra : Animal
    {
        public Zebra(string nome, int idade, string especie, string cor) : base(nome, idade, especie, cor)
        {

        }
        public override void Comer()
        {
            Console.WriteLine($"Eu Zebra estou comendo nhamnham");
        }
        public override void Dormir()
        {
            Console.WriteLine($"Eu Zebra estou dormindo ZzZzZzzz");
        }

        public void Zurrar()
        {
            Console.WriteLine("hinn in in");
        }
    }
}
