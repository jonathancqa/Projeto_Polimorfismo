using System;
using Zoologico.src;

namespace Zoologico
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var simba = new Leao("Simba", 5, "Leão", "Laranja");
            var gloria = new Hipopotamo("Velma", 3, "Hipopotamo", "Cinza");
            var marty = new Zebra("Marty", 6, "Zebra", "Branca com Listras Pretas");
            var fly = new Harpia("Fly", 2, "Harpia", "Marrom e Branco");

            Console.WriteLine("Animais do Zoologico \n");

            Console.WriteLine(simba.ToString());
            simba.Rugir();
            Console.WriteLine();

            Console.WriteLine(gloria.ToString());
            gloria.Roncar();
            Console.WriteLine();

            Console.WriteLine(marty.ToString());
            marty.Zurrar();
            Console.WriteLine();

            Console.WriteLine(fly.ToString());
            fly.Grito();
            Console.WriteLine();

        }
    }
}
