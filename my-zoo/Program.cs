using System;

namespace my_zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        abstract class Animal

        {
            public abstract void eats();

            public abstract void makeSound();

            public abstract bool HasHair { get; }
        }

        abstract class Mammal : Animal
        {
            public int numbLegs { get; set; }

            public abstract bool babyIsNursed { get; }
        }
    }
}
