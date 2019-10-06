using DellChallenge.B.Models;
using System;

namespace DellChallenge.B
{
    class Program
    {
        static void Main(string[] args)
        {
            // Given the classes and interface below, please constructor the proper hierarchy.
            // Feel free to refactor and restructure the classes/interface below.
            // (Hint: Not all species and Fly and/or Swim)
            Human human = new Human();
            human.GetSpecies();
            human.Drink();
            human.Eat();
            Console.WriteLine();
            
            Bird bird = new Bird();
            bird.GetSpecies();
            bird.Fly();
            bird.Drink();
            bird.Eat();
            Console.WriteLine();

            Fish fish = new Fish();
            fish.GetSpecies();
            fish.Swim();
            fish.Eat();
            fish.Drink();
            Console.WriteLine();

            Console.ReadKey();
                 
        }
    }
    
}

