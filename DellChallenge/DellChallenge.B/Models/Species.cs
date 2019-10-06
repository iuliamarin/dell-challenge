using DellChallenge.B.Interfaces;
using System;

namespace DellChallenge.B.Models
{
    public abstract class Species : ISpecies
    {
        public virtual void Drink()
        {
            Console.WriteLine("I am drinking");
        }

        public virtual void Eat()
        {
            Console.WriteLine("I am eating");
        }

        public abstract void GetSpecies();
    }
}
