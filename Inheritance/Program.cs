using System;
using System.Collections.Generic;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {

            var swan = new Bird();
            swan.Name = "Swan";
            swan.Age = 7;
            swan.CanMove = true;
            swan.FeatherColor = "white";
            swan.ConsumedByHumans = false;
            swan.HasBeak = false;
            swan.WebbedFeet = true;
            swan.Diet = "herbivore";


            var lizard = new Reptile();
            lizard.Name = "Komodo Dragon";
            lizard.Age = 20;
            lizard.CanMove = true;
            lizard.ScaleColor = "yellow-gray";
            lizard.HasLegs = true;
            lizard.LaysEggs = true;
            lizard.TailLength = 9;
            lizard.Diet = "carnivore";

            var wildlifePark = new List<Animal>() { swan, lizard };

            foreach(var animal in wildlifePark)
            {
                Console.WriteLine($"This is a {animal.Name} and it is a {animal.Diet}. Believe it or not, this critter is {animal.Age} years old!");
            }

        }
    }
}
