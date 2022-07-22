using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoologico.src
{
    public class Leao : Animal
    {
        public Leao(string nome, int idade, string especie, string cor) : base(nome, idade, especie, cor)
        {

        }

        public override void Comer()
        {
            Console.WriteLine($"Eu Leão estou comendo nhamnham");
        }
        public override void Dormir()
        {
            Console.WriteLine($"Eu Leão estou dormindo ZzZzZzzz");
        }
        public void Rugir()
        {
            Console.WriteLine("Roooaaarrrr");
        }
    }
}
