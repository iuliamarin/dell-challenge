using DellChallenge.B.Interfaces;
using System;

namespace DellChallenge.B.Models
{
    public class Bird : Species, IFlyer
    {
        public void Fly()
        {
            Console.WriteLine("I can fly");
        }

        public override void GetSpecies()
        {
            Console.WriteLine("I am a bird");
        }
    }
}
