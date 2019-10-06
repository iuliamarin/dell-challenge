using System;

namespace DellChallenge.A
{
    class Program
    {
        static void Main(string[] args)
        {
            // State and explain console output order.
            // This is an example of inheritance in C#. The order of constructors in derived classes are executed 
            // from the base class to the most derived class. Inside constructor B, the value of Age is set by accesing its 
            // setter from base class, which also prints to console A.Age. If we were to have a different implementation for
            // the Age setter inside B, we would add a new private prop for _age in B class and use the "new" keyword for 
            // overriding A.Age. 
            new B();
            Console.ReadKey();
        }
    }

    class A
    {
        private int _age;
        public int Age
        {
            get { return _age; }
            set
            {
                _age = value;
                Console.WriteLine("A.Age");
            }
        }


        public A()
        {
            Console.WriteLine("A.A()");
        }
    }

    class B : A
    {
        public B()
        {
            Console.WriteLine("B.B()");
            Age = 0;
        }
    }
}
