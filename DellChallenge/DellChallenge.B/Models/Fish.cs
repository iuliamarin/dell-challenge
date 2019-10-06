using DellChallenge.B.Interfaces;
using System;

namespace DellChallenge.B.Models
{
    public class Fish : Species, ISwimmer
    {
        public void Swim()
        {
            Console.WriteLine("I can swim");
        }

        public override void GetSpecies()
        {
            Console.WriteLine("I am a fish");
        }
    }
}
