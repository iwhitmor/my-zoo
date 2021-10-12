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
            public abstract string eats();

            public abstract string makeSound();

            public abstract bool HasHair { get; }
        }

        abstract class Mammal : Animal
        {
            public abstract int NumLegs { get; }

            public bool BabyIsNursed { get; }
        }

        class Cow : Mammal
        {
            public override string eats()
            {
                return "Hay";
            }

            public override string makeSound()
            {
                return "Moooo";
            }

            public override int NumLegs = 4;

            public bool BabyIsNursed => true;

            public override bool HasHair => true;
        }
    }
}
