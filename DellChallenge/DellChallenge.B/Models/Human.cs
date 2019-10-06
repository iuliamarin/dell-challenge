using System;

namespace DellChallenge.B.Models
{
    public class Human : Species
    {
        public override void Drink()
        {
            Console.WriteLine("I am drinking using my mouth from the glass");
        }

        public override void Eat()
        {
            Console.WriteLine("I am eating only cooked food");
        }

        public override void GetSpecies()
        {
            Console.WriteLine("I am human");
        }

    }
}
