using System;

namespace DellChallenge.C
{
    class Program
    {
        static void Main(string[] args)
        {
            // Please refactor the code below whilst taking into consideration the following aspects:
            //      1. clean coding
            //      2. naming standards
            //      3. code reusability, hence maintainability
            Calculate();
            Console.ReadKey();
        }

        private static void Calculate()
        {
            Console.WriteLine(Calculator.Add(1));
            Console.WriteLine(Calculator.Add());
            Console.WriteLine(Calculator.Add(1, 3));
            Console.WriteLine(Calculator.Add(1, 3, 5));
            
        }
    }

    public static class Calculator
    {

        public static int Add(params int[] args)
        {
            int result = 0;
            if (args.Length > 0) {
                for (int i = 0; i < args.Length; i++) {
                    result = result + args[i];
                }
            }
            return result;
        }
    }
}
