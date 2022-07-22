using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoologico.src
{
    public class Harpia : Animal
    {
        public Harpia(string nome, int idade, string especie, string cor) : base(nome, idade, especie, cor)
        {
        }
        public override void Comer()
        {
            Console.WriteLine($"Eu Hapia estou comendo nhamnham");
        }
        public override void Dormir()
        {
            Console.WriteLine($"Eu Harpia estou dormindo ZzZzZzzz");
        }
        public void Grito()
        {
            Console.WriteLine("Piiiiiaaaaaaaaa");
        }

    }
}
