using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoologico.src
{
    public class Animal
    {
        string Nome { get; set; }
        
        int Idade { get; set; }
        
        string Especie { get; set; }
        
        string Cor { get; set; }

        public Animal(string nome, int idade, string especie, string cor)
        {
            Nome = nome;
            Idade = idade;
            Especie = especie;
            Cor = cor;
        }

        public virtual void Comer()
        {
            Console.WriteLine($"{Nome} está comendo");
        }
        
        public virtual void Dormir()
        {
            Console.WriteLine($"{Nome} está dormindo");
        }

        public override string ToString()
        {
            return $"Nome:{Nome} " +
                   $"Idade:{Idade} " +
                   $"Especie: {Especie} " +
                   $"Cor: {Cor}";
        }
    }
}
