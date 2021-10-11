using System;

namespace my_zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Cow cow = new Cow();
            cow.eats();
            cow.makeSound();
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

        class Cow : Mammal
        {
            public override void eats()
            {
                Console.WriteLine("Eats: Hay");
            }

            public override void makeSound()
            {
                Console.WriteLine("Says Moooo");
            }

            public override bool babyIsNursed => true;

            public override bool HasHair => true;
        }
    }
}
