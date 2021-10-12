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
            public abstract int NumLegs { get; set; }

            public bool BabyIsNursed { get; }
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

            public override int NumLegs = 4;

            public bool BabyIsNursed => true;

            public override bool HasHair => true;
        }
    }
}
