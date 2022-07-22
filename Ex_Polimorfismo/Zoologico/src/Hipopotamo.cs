using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoologico.src
{
    public class Hipopotamo : Animal
    {
        public Hipopotamo(string nome, int idade, string especie, string cor) : base(nome, idade, especie, cor)
        {

        }

        public override void Comer()
        {
            Console.WriteLine($"Eu Hipopótamo estou comendo nhamnham");
        }
        public override void Dormir()
        {
            Console.WriteLine($"Eu Hipopótamo estou dormindo ZzZzZzzz");
        }
        public void Roncar()
        {
            Console.WriteLine("Rooooorrrr");
        }
    }

}
